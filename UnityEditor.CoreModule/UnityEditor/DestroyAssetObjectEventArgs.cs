using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct DestroyAssetObjectEventArgs
{
    public UnityEditor.GUID guid { get; }
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public DestroyAssetObjectEventArgs(UnityEditor.GUID guid, int instanceId, SceneManagement.Scene scene);

}

}
