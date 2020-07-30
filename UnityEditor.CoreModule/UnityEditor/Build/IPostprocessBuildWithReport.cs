using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPostprocessBuildWithReport : UnityEditor.Build.IOrderedCallback
{
    public void OnPostprocessBuild(UnityEditor.Build.Reporting.BuildReport report);

}

}