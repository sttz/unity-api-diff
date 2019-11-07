using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPreprocessShaders : UnityEditor.Build.IOrderedCallback
{
    public void OnProcessShader(Shader shader, UnityEditor.Rendering.ShaderSnippetData snippet, System.Collections.Generic.IList<UnityEditor.Rendering.ShaderCompilerData> data);

}

}
