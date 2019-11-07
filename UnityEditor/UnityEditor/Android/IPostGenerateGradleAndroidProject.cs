using System;
using UnityEngine;

namespace UnityEditor.Android
{

public interface IPostGenerateGradleAndroidProject : UnityEditor.Build.IOrderedCallback
{
    public void OnPostGenerateGradleAndroidProject(string path);

}

}
