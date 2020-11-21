using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IPostprocessBuild : UnityEditor.Build.IOrderedCallback
{
    public void OnPostprocessBuild(UnityEditor.BuildTarget target, string path);

}

}
