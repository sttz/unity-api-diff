using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPreprocessShaders : UnityEditor.Build.IOrderedCallback
{
    public void OnProcessShader(Shader shader, UnityEditor.Rendering.ShaderSnippetData snippet, IList<UnityEditor.Rendering.ShaderCompilerData> data);

}

}
