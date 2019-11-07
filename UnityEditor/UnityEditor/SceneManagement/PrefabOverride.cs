using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class PrefabOverride
{
    protected PrefabOverride();

    public void Apply(string prefabAssetPath, UnityEditor.InteractionMode mode);
    public void Apply();
    public void Apply(string prefabAssetPath);
    public void Apply(UnityEditor.InteractionMode mode);
    protected Object FindApplyTargetAssetObject(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert(UnityEditor.InteractionMode mode);
    public void Revert();

}

}
