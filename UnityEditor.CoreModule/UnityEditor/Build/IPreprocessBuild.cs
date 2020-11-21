using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPreprocessBuild : UnityEditor.Build.IOrderedCallback
{
    public void OnPreprocessBuild(UnityEditor.BuildTarget target, string path);

}

}
