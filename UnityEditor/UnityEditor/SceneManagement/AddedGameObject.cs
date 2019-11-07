using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class AddedGameObject : UnityEditor.SceneManagement.PrefabOverride
{
    public GameObject instanceGameObject { get; set; }
    public int siblingIndex { get; set; }

    public AddedGameObject();

    public void Apply(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert();

}

}
