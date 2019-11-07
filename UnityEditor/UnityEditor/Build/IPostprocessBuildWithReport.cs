using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPostprocessBuildWithReport : UnityEditor.Build.IOrderedCallback
{
    public void OnPostprocessBuild(UnityEditor.Build.Reporting.BuildReport report);

}

}
