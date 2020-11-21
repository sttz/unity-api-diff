using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ChangeGameObjectStructureEventArgs
{
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public ChangeGameObjectStructureEventArgs(int instanceId, SceneManagement.Scene scene);

}

}
