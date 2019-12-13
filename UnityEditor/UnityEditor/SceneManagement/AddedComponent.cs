using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public class AddedComponent : UnityEditor.SceneManagement.PrefabOverride
{
    public Component instanceComponent { get; set; }

    public AddedComponent();

    public void Apply(string prefabAssetPath, UnityEditor.InteractionMode mode);
    public Object GetAssetObject();
    public void Revert(UnityEditor.InteractionMode mode);

}

}