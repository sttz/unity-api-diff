using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPreprocessBuildWithReport : UnityEditor.Build.IOrderedCallback
{
    public void OnPreprocessBuild(UnityEditor.Build.Reporting.BuildReport report);

}

}
