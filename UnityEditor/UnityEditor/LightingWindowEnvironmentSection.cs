using System;
using System.Collections;
using System.Collections.Generic;
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
