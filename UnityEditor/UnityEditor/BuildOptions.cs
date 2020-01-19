using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum BuildOptions
{
    None = 0,
    StripDebugSymbols = 0,
    CompressTextures = 0,
    Il2CPP = 0,
    ForceOptimizeScriptCompilation = 0,
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
    ConnectToHost = 4096,
    EnableHeadlessMode = 16384,
    BuildScriptsOnly = 32768,
    PatchPackage = 65536,
    ForceEnableAssertions = 131072,
    CompressWithLz4 = 262144,
    CompressWithLz4HC = 524288,
    ComputeCRC = 1048576,
    StrictMode = 2097152,
    IncludeTestAssemblies = 4194304,
    NoUniqueIdentifier = 8388608,
    WaitForPlayerConnection = 33554432,
    EnableCodeCoverage = 67108864,
    EnableDeepProfilingSupport = 268435456,
    DetailedBuildReport = 536870912,
}

}
