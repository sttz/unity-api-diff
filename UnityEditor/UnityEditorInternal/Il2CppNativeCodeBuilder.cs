using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public abstract class Il2CppNativeCodeBuilder
{
    public IEnumerable<string> AdditionalIl2CPPArguments { get; }
    public string BaselibLibraryDirectory { get; }
    public string CacheDirectory { get; }
    public string CompilerArchitecture { get; }
    public string CompilerFlags { get; }
    public string CompilerPlatform { get; }
    public string LinkerFlags { get; }
    public bool LinkLibIl2CppStatically { get; }
    public string PluginPath { get; }
    public bool SetsUpEnvironment { get; }

    public Il2CppNativeCodeBuilder(string baselibLibraryDirectory);

    public IEnumerable<string> ConvertIncludesToFullPaths(IEnumerable<string> relativeIncludePaths);
    public string ConvertOutputFileToFullPath(string outputFileRelativePath);
    protected void SetupEnvironment(System.Diagnostics.ProcessStartInfo startInfo);
    public void SetupStartInfo(System.Diagnostics.ProcessStartInfo startInfo);

}

}
