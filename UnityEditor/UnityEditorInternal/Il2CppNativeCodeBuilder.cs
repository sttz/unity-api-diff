using System;
using UnityEngine;

namespace UnityEditorInternal
{

public abstract class Il2CppNativeCodeBuilder
{
    public System.Collections.Generic.IEnumerable<string> AdditionalIl2CPPArguments { get; }
    public string CacheDirectory { get; }
    public string CompilerArchitecture { get; }
    public string CompilerFlags { get; }
    public string CompilerPlatform { get; }
    public string LinkerFlags { get; }
    public bool LinkLibIl2CppStatically { get; }
    public string PluginPath { get; }
    public bool SetsUpEnvironment { get; }

    protected Il2CppNativeCodeBuilder();

    public System.Collections.Generic.IEnumerable<string> ConvertIncludesToFullPaths(System.Collections.Generic.IEnumerable<string> relativeIncludePaths);
    public string ConvertOutputFileToFullPath(string outputFileRelativePath);
    protected void SetupEnvironment(System.Diagnostics.ProcessStartInfo startInfo);
    public void SetupStartInfo(System.Diagnostics.ProcessStartInfo startInfo);

}

}
