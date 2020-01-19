using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class DefaultLightingExplorerExtension : UnityEditor.ILightingExplorerExtension
{
    public DefaultLightingExplorerExtension();

    public UnityEditor.LightingExplorerTab[] GetContentTabs();
    protected Object[] GetEmissives();
    protected UnityEditor.LightingExplorerTableColumn[] GetEmissivesColumns();
    protected UnityEditor.LightingExplorerTableColumn[] GetLightColumns();
    protected UnityEditor.LightingExplorerTableColumn[] GetLightProbeColumns();
    protected Object[] GetLightProbes();
    protected Object[] GetLights();
    protected UnityEditor.LightingExplorerTableColumn[] GetReflectionProbeColumns();
    protected Object[] GetReflectionProbes();
    public void OnDisable();
    public void OnEnable();

}

}
