using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{

public struct ShaderSnippetData
{
    public string passName { get; }
    public Rendering.PassType passType { get; }
    public UnityEditor.Rendering.ShaderType shaderType { get; }

}

}
