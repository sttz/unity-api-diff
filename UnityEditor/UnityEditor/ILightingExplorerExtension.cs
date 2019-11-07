using System;
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
