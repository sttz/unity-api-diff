using System;
using UnityEngine;

namespace UnityEditor
{

public abstract class LightingWindowEnvironmentSection
{
    protected LightingWindowEnvironmentSection();

    public void OnDisable();
    public void OnEnable();
    public void OnInspectorGUI();

}

}
