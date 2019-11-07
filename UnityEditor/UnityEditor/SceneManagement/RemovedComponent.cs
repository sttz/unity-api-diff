using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class RemovedComponent : UnityEditor.SceneManagement.PrefabOverride
{
    public Component assetComponent { get; set; }
    public GameObject containingInstanceGameObject { get; set; }

    public RemovedComponent();

    public void Apply(string prefabAssetPath, UnityEditor.InteractionMode mode);
    public Object GetAssetObject();
    public void Revert(UnityEditor.InteractionMode mode);

}

}
