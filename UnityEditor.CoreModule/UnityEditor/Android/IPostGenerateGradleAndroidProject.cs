using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Android
{

public interface IPostGenerateGradleAndroidProject : UnityEditor.Build.IOrderedCallback
{
    public void OnPostGenerateGradleAndroidProject(string path);

}

}
