using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IUnityLinkerProcessor : UnityEditor.Build.IOrderedCallback
{
    public string GenerateAdditionalLinkXmlFile(UnityEditor.Build.Reporting.BuildReport report, UnityEditor.UnityLinker.UnityLinkerBuildPipelineData data);
    public void OnAfterRun(UnityEditor.Build.Reporting.BuildReport report, UnityEditor.UnityLinker.UnityLinkerBuildPipelineData data);
    public void OnBeforeRun(UnityEditor.Build.Reporting.BuildReport report, UnityEditor.UnityLinker.UnityLinkerBuildPipelineData data);

}

}
