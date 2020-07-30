using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ChangeGameObjectStructureHierarchyEventArgs
{
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public ChangeGameObjectStructureHierarchyEventArgs(int instanceId, SceneManagement.Scene scene);

}

}
