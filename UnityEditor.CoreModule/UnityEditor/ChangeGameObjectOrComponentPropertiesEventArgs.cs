using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ChangeGameObjectOrComponentPropertiesEventArgs
{
    public int instanceId { get; }
    public SceneManagement.Scene scene { get; }

    public ChangeGameObjectOrComponentPropertiesEventArgs(int instanceId, SceneManagement.Scene scene);

}

}
