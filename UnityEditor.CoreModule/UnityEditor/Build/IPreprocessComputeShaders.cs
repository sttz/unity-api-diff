using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPreprocessComputeShaders : UnityEditor.Build.IOrderedCallback
{
    public void OnProcessComputeShader(ComputeShader shader, string kernelName, IList<UnityEditor.Rendering.ShaderCompilerData> data);

}

}
