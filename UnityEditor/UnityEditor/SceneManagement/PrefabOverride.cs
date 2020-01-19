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
    public void Apply(string prefabAssetPath);
    protected Object FindApplyTargetAssetObject(string prefabAssetPath);
    public Object GetAssetObject();
    public void Revert();

}

}
