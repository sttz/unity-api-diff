using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public abstract class PrefabOverride
{
    protected PrefabOverride();

    public void Apply();
    public void Apply(UnityEditor.InteractionMode mode);
    public void Apply(string prefabAssetPath);
    public void Apply(string prefabAssetPath, UnityEditor.InteractionMode mode);
    protected Object FindApplyTargetAssetObject(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert();
    public void Revert(UnityEditor.InteractionMode mode);

}

}
