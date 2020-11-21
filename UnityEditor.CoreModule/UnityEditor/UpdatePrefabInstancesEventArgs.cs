using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct UpdatePrefabInstancesEventArgs
{
    public ReadOnly<int> instanceIds { get; }
    public SceneManagement.Scene scene { get; }

    public UpdatePrefabInstancesEventArgs(SceneManagement.Scene scene, ReadOnly<int> instanceIds);

}

}
