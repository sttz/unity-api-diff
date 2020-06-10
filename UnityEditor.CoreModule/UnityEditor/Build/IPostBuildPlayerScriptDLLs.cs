using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPostBuildPlayerScriptDLLs : UnityEditor.Build.IOrderedCallback
{
    public void OnPostBuildPlayerScriptDLLs(UnityEditor.Build.Reporting.BuildReport report);

}

}
