using System;
using UnityEngine;

namespace UnityEngine.SceneManagement
{

public struct CreateSceneParameters
{
    public SceneManagement.LocalPhysicsMode localPhysicsMode { get; set; }

    public CreateSceneParameters(SceneManagement.LocalPhysicsMode physicsMode);

}

}
