using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class PrefabOverride
{
    protected PrefabOverride();

    public void Apply(string prefabAssetPath);
    public void Apply();
    protected Object FindApplyTargetAssetObject(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert();

}

}
