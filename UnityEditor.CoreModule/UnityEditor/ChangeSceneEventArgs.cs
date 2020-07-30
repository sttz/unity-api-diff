using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ChangeSceneEventArgs
{
    public SceneManagement.Scene scene { get; }

    public ChangeSceneEventArgs(SceneManagement.Scene scene);

}

}
