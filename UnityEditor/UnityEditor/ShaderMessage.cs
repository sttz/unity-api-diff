using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ShaderMessage : IEquatable<UnityEditor.ShaderMessage>
{
    public string file { get; }
    public int line { get; }
    public string message { get; }
    public string messageDetails { get; }
    public UnityEditor.Rendering.ShaderCompilerPlatform platform { get; }
    public UnityEditor.Rendering.ShaderCompilerMessageSeverity severity { get; }

    public ShaderMessage(string msg, UnityEditor.Rendering.ShaderCompilerMessageSeverity sev = 0);

    public bool Equals(object obj);
    public bool Equals(UnityEditor.ShaderMessage other);
    public int GetHashCode();

}

}
