using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct DestroyGameObjectHierarchyEventArgs
{
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public DestroyGameObjectHierarchyEventArgs(int instanceId, SceneManagement.Scene scene);

}

}
