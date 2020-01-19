using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SceneManagement
{

public struct LoadSceneParameters
{
    public SceneManagement.LoadSceneMode loadSceneMode { get; set; }
    public SceneManagement.LocalPhysicsMode localPhysicsMode { get; set; }

    public LoadSceneParameters(SceneManagement.LoadSceneMode mode);
    public LoadSceneParameters(SceneManagement.LoadSceneMode mode, SceneManagement.LocalPhysicsMode physicsMode);

}

}
