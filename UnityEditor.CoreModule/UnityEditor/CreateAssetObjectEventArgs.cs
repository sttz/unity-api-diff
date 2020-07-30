using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct CreateAssetObjectEventArgs
{
    public UnityEditor.GUID guid { get; }
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public CreateAssetObjectEventArgs(UnityEditor.GUID guid, int instanceId, SceneManagement.Scene scene);

}

}
