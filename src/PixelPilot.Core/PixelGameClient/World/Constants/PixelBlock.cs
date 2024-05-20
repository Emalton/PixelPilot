﻿namespace PixelPilot.PixelGameClient.World.Constants;

/// <summary>
/// All blocks available in the game as of 29-04-2024.
/// </summary>
public enum PixelBlock : int
{
  Empty = 0,
  GravityLeft = 1,
  GravityUp = 2,
  GravityRight = 3,
  GravityDown = 4,
  GravityDot = 5,
  GravitySlowDot = 6,
  BoostLeft = 7,
  BoostUp = 8,
  BoostRight = 9,
  BoostDown = 10,
  JungleVineVertical = 11,
  JungleVineHorizontal = 12,
  Crown = 13,
  Trophy = 14,
  KeyRed = 25,
  KeyGreen = 26,
  KeyBlue = 27,
  Coin = 15,
  BlueCoin = 16,
  SpawnPoint = 17,
  Checkpoint = 18,
  ResetPoint = 19,
  GodModeActivator = 20,
  Portal = 21,
  PortalInvisible = 22,
  Water = 23,
  WaterSurface = 24,
  KeyDoorRed = 28,
  KeyDoorGreen = 29,
  KeyDoorBlue = 30,
  CoinDoor = 31,
  BlueCoinDoor = 32,
  KeyGateRed = 33,
  KeyGateGreen = 34,
  KeyGateBlue = 35,
  CoinGate = 36,
  BlueCoinGate = 37,
  LocalSwitch = 38,
  LocalSwitchActivator = 39,
  LocalSwitchResetter = 40,
  LocalSwitchDoor = 41,
  LocalSwitchGate = 42,
  GlobalSwitch = 43,
  GlobalSwitchActivator = 44,
  GlobalSwitchResetter = 45,
  GlobalSwitchDoor = 46,
  GlobalSwitchGate = 47,
  DeathDoor = 48,
  DeathGate = 49,
  Spikes = 50,
  SpikesCenter = 51,
  Fire = 52,
  BasicWhite = 53,
  BasicGray = 54,
  BasicBlack = 55,
  BasicRed = 56,
  BasicOrange = 57,
  BasicYellow = 58,
  BasicGreen = 59,
  BasicCyan = 60,
  BasicBlue = 61,
  BasicMagenta = 62,
  BasicWhiteBg = 63,
  BasicGrayBg = 64,
  BasicBlackBg = 65,
  BasicRedBg = 66,
  BasicOrangeBg = 67,
  BasicYellowBg = 68,
  BasicGreenBg = 69,
  BasicCyanBg = 70,
  BasicBlueBg = 71,
  BasicMagentaBg = 72,
  BeveledWhite = 73,
  BeveledGray = 74,
  BeveledBlack = 75,
  BeveledRed = 76,
  BeveledOrange = 77,
  BeveledYellow = 78,
  BeveledGreen = 79,
  BeveledCyan = 80,
  BeveledBlue = 81,
  BeveledMagenta = 82,
  BricksWhite = 83,
  BricksGray = 84,
  BricksBlack = 85,
  BricksRed = 86,
  BricksBrown = 87,
  BricksOlive = 88,
  BricksGreen = 89,
  BricksTeal = 90,
  BricksBlue = 91,
  BricksPurple = 92,
  BricksWhiteBg = 93,
  BricksGrayBg = 94,
  BricksBlackBg = 95,
  BricksRedBg = 96,
  BricksBrownBg = 97,
  BricksOliveBg = 98,
  BricksGreenBg = 99,
  BricksTealBg = 100,
  BricksBlueBg = 101,
  BricksPurpleBg = 102,
  NormalWhiteBg = 103,
  NormalGrayBg = 104,
  NormalBlackBg = 105,
  NormalRedBg = 106,
  NormalOrangeBg = 107,
  NormalYellowBg = 108,
  NormalGreenBg = 109,
  NormalCyanBg = 110,
  NormalBlueBg = 111,
  NormalMagentaBg = 112,
  DarkWhiteBg = 113,
  DarkGrayBg = 114,
  DarkBlackBg = 115,
  DarkRedBg = 116,
  DarkOrangeBg = 117,
  DarkYellowBg = 118,
  DarkGreenBg = 119,
  DarkCyanBg = 120,
  DarkBlueBg = 121,
  DarkMagentaBg = 122,
  CheckerWhiteBg = 123,
  CheckerGrayBg = 124,
  CheckerBlackBg = 125,
  CheckerRedBg = 126,
  CheckerOrangeBg = 127,
  CheckerYellowBg = 128,
  CheckerGreenBg = 129,
  CheckerCyanBg = 130,
  CheckerBlueBg = 131,
  CheckerMagentaBg = 132,
  PastelRedBg = 133,
  PastelOrangeBg = 134,
  PastelYellowBg = 135,
  PastelLimeBg = 136,
  PastelGreenBg = 137,
  PastelCyanBg = 138,
  PastelBlueBg = 139,
  PastelPurpleBg = 140,
  BricksGrassLeftEdge = 142,
  BricksGrass = 141,
  BricksGrassRightEdge = 143,
  MetalSilver = 144,
  MetalCopper = 145,
  MetalGold = 146,
  HazardStripes = 147,
  DarkHazardStripes = 148,
  FaceBlock = 149,
  NoFaceBlock = 150,
  BlackBlock = 151,
  FullBlackBlock = 152,
  SecretAppear = 153,
  SecretDisappear = 154,
  SecretInvisible = 155,
  GlassRed = 156,
  GlassOrange = 157,
  GlassYellow = 158,
  GlassGreen = 159,
  GlassCyan = 160,
  GlassBlue = 161,
  GlassPurple = 162,
  GlassMagenta = 163,
  MineralsRed = 164,
  MineralsOrange = 165,
  MineralsYellow = 166,
  MineralsGreen = 167,
  MineralsCyan = 168,
  MineralsBlue = 169,
  MineralsPurple = 170,
  MineralsMagenta = 171,
  FactoryMetalCrate = 172,
  FactoryStone = 173,
  FactoryWood = 174,
  FactoryWoodenCrate = 175,
  FactoryScales = 176,
  MeadowGrassLeft = 177,
  MeadowGrassMiddle = 178,
  MeadowGrassRight = 179,
  MeadowBushLeft = 180,
  MeadowBushMiddle = 181,
  MeadowBushRight = 182,
  MeadowYellowFlower = 183,
  MeadowSmallBush = 184,
  EasterEggBlue = 185,
  EasterEggPink = 186,
  EasterEggYellow = 187,
  EasterEggRed = 188,
  EasterEggGreen = 189,
  CandyPink = 190,
  CandyBlue = 191,
  CandyPlatformPink = 192,
  CandyPlatformRed = 193,
  CandyPlatformCyan = 194,
  CandyPlatformGreen = 195,
  CandyCane = 196,
  CandyLicorice = 197,
  CandyChocolate = 198,
  CandyCreamSmall = 199,
  CandyCreamLarge = 200,
  CandyGumdropRed = 201,
  CandyGumdropGreen = 202,
  CandyGumdropPink = 203,
  CandyPinkBg = 204,
  CandyBlueBg = 205,
  BeachSand = 206,
  BeachParasol = 207,
  BeachSandPileRight = 208,
  BeachSandPileLeft = 209,
  BeachRock = 210,
  BeachDryBush = 211,
  JungleFaceBlock = 212,
  JunglePlatform = 213,
  JungleGray = 214,
  JungleRed = 215,
  JungleBlue = 216,
  JungleOlive = 217,
  JunglePot = 218,
  JunglePlant = 219,
  JunglePotBroken = 220,
  JungleStatue = 221,
  JungleGrayBg = 222,
  JungleRedBg = 223,
  JungleBlueBg = 224,
  JungleOliveBg = 225,
  JungleLeavesLightBg = 226,
  JungleLeavesMediumBg = 227,
  JungleLeavesDarkBg = 228
}