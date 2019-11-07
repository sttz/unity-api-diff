using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPreprocessBuild : UnityEditor.Build.IOrderedCallback
{
    public void OnPreprocessBuild(UnityEditor.BuildTarget target, string path);

}

}
