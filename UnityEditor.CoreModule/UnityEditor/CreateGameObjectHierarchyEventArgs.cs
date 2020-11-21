using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct CreateGameObjectHierarchyEventArgs
{
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public CreateGameObjectHierarchyEventArgs(int instanceId, SceneManagement.Scene scene);

}

}
