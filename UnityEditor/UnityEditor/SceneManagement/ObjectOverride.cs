using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class ObjectOverride : UnityEditor.SceneManagement.PrefabOverride
{
    public Object instanceObject { get; set; }

    public ObjectOverride();

    public void Apply(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert();

}

}
