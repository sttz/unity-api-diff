using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public interface ILightingExplorerExtension
{
    public UnityEditor.LightingExplorerTab[] GetContentTabs();
    public void OnDisable();
    public void OnEnable();

}

}
