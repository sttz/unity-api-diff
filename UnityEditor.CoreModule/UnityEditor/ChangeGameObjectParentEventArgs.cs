using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ChangeGameObjectParentEventArgs
{
    public int instanceId { get; }
    public int newParentInstanceId { get; }
    public SceneManagement.Scene newScene { get; }
    public int previousParentInstanceId { get; }
    public SceneManagement.Scene previousScene { get; }

    public ChangeGameObjectParentEventArgs(int instanceId, SceneManagement.Scene previousScene, int previousParentInstanceId, SceneManagement.Scene newScene, int newParentInstanceId);

}

}
