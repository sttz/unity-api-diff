using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ChangeAssetObjectPropertiesEventArgs
{
    public UnityEditor.GUID guid { get; }
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public ChangeAssetObjectPropertiesEventArgs(UnityEditor.GUID guid, int instanceId, SceneManagement.Scene scene);

}

}
