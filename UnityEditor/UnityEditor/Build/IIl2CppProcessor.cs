using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IIl2CppProcessor : UnityEditor.Build.IOrderedCallback
{
    public void OnBeforeConvertRun(UnityEditor.Build.Reporting.BuildReport report, UnityEditor.Il2Cpp.Il2CppBuildPipelineData data);

}

}
