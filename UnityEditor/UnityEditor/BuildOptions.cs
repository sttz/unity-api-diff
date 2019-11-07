using System;
using UnityEngine;

namespace UnityEditor
{

public enum BuildOptions
{
    None = 0,
    Development = 1,
    AutoRunPlayer = 4,
    ShowBuiltPlayer = 8,
    BuildAdditionalStreamedScenes = 16,
    AcceptExternalModificationsToPlayer = 32,
    InstallInBuildFolder = 64,
    WebPlayerOfflineDeployment = 128,
    ConnectWithProfiler = 256,
    AllowDebugging = 512,
    SymlinkLibraries = 1024,
    UncompressedAssetBundle = 2048,
    StripDebugSymbols = 0,
    CompressTextures = 0,
    ConnectToHost = 4096,
    EnableHeadlessMode = 16384,
    BuildScriptsOnly = 32768,
    PatchPackage = 65536,
    Il2CPP = 0,
    ForceEnableAssertions = 131072,
    CompressWithLz4 = 262144,
    CompressWithLz4HC = 524288,
    ForceOptimizeScriptCompilation = 0,
    ComputeCRC = 1048576,
    StrictMode = 2097152,
    IncludeTestAssemblies = 4194304,
    NoUniqueIdentifier = 8388608,
    Reserved1 = 16777216,
    WaitForPlayerConnection = 33554432,
    EnableCodeCoverage = 67108864,
}

}
