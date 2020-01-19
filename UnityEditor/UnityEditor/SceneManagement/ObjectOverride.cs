using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class ObjectOverride : UnityEditor.SceneManagement.PrefabOverride
{
    public UnityEditor.SceneManagement.PrefabOverride coupledOverride { get; set; }
    public Object instanceObject { get; set; }

    public ObjectOverride();

    public void Apply(string prefabAssetPath, UnityEditor.InteractionMode mode);
    public Object GetAssetObject();
    public void Revert(UnityEditor.InteractionMode mode);

}

}
