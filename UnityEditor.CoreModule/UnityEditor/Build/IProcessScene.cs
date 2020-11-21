using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IProcessScene : UnityEditor.Build.IOrderedCallback
{
    public void OnProcessScene(SceneManagement.Scene scene);

}

}
