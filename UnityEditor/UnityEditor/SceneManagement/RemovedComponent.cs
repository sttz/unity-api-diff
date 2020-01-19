using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class RemovedComponent : UnityEditor.SceneManagement.PrefabOverride
{
    public Component assetComponent { get; set; }
    public GameObject containingInstanceGameObject { get; set; }

    public RemovedComponent();

    public void Apply(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert();

}

}
