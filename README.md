# Pixel Pilot
[![NuGet Version](https://img.shields.io/nuget/vpre/PixelPilot.Core?style=flat-square&logo=nuget&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FPixelPilot.Core%2F%20)](https://www.nuget.org/packages/PixelPilot.Core/) ![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/MartenM/PixelPilot/dotnet.yml?branch=main&style=flat-square)


A C# library for interacting with the game [PixelWalker](https://pixelwalker.net)

![Example bot](https://i.imgur.com/47bDpAc.gif)

## Features
* Strongly typed packets.
* PixelPilotCore has minor abstractions.
* Split into multiple projects. Use only what you need.

### Projects:
* **PixelPilotCore**: The core of the project. Bare minimum client to interact with the game.
* **PixelPilotTests**: All test related to the project.
* **PixelPilotExample**: An example bot.

### To-Do's:
- [x] Implement all packets.
- [ ] Implement common World and Player abstractions (seperate package)

## Example
```csharp
using Microsoft.Extensions.Configuration;
using PixelPilot.PixelGameClient;
using PixelPilot.PixelGameClient.Messages.Received;
using PixelPilot.PixelGameClient.Messages.Send;
using PixelPilot.PixelGameClient.World;
using PixelPilotExample;

// Load the configuration. Don't store your account token in the code :)
var config = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build().Get<BasicConfig>();

if (config == null)
{
    Console.WriteLine("The configuration file could not be loaded.");
    return;
}

// Create a client.
var client = new PixelPilotClient(config.AccountToken, false);

// Create a PixelWorld class and attach the client to it.
// Allow it to listen to client updates. Not required!
var world = new PixelWorld();
client.OnPacketReceived += world.HandlePacket;
world.OnBlockPlaced += (_, playerId, oldBlock, _) =>
{
    if (client.BotId == playerId) return;
    client.Send(oldBlock.AsPacketOut());
};


// Executed when the client receives a packet!
client.OnPacketReceived += (_, packet) =>
{
    switch (packet)
    {
        // Use strongly typed packets!
        case PlayerChatPacket { Message: ".stop" }:
            client.Disconnect();
            Environment.Exit(0);
            return;
        case PlayerChatPacket { Message: ".ping" } chat:
        {
            client.Send(new PlayerChatOutPacket($"Pong! ({chat.Id})"));
            break;
        }
        case PlayerJoinPacket join:
            client.Send(new PlayerChatOutPacket($"/giveedit {join.Username}"));
            break;
    }
};

// Executed once the client receives INIT
// Make a platform and do some silly loops.
client.OnClientConnected += (_) =>
{
    client.Send(new PlayerChatOutPacket("Hello world using the PixelPilot API."));
    Thread.Sleep(250);
    PlatformUtil.GetThread(client).Start();
    client.Send(new PlayerMoveOutPacket(592, 1056, 0, 0, 0, 0, 0, 0, false, false, 100)); 
};

// Connect to a room.
await client.Connect("r082b210d67df52");

// Don't terminate.
Thread.Sleep(-1);
```


Enjoy the library? Leave a ⭐

