using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SceneManagement
{

public struct CreateSceneParameters
{
    public SceneManagement.LocalPhysicsMode localPhysicsMode { get; set; }

    public CreateSceneParameters(SceneManagement.LocalPhysicsMode physicsMode);

}

}
