using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IProcessSceneWithReport : UnityEditor.Build.IOrderedCallback
{
    public void OnProcessScene(SceneManagement.Scene scene, UnityEditor.Build.Reporting.BuildReport report);

}

}
