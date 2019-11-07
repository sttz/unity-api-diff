using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IActiveBuildTargetChanged : UnityEditor.Build.IOrderedCallback
{
    public void OnActiveBuildTargetChanged(UnityEditor.BuildTarget previousTarget, UnityEditor.BuildTarget newTarget);

}

}
