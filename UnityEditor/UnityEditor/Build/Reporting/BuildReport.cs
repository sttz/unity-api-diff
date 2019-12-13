using System;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public sealed class BuildReport : Object
{
    public UnityEditor.Build.Reporting.BuildFile[] files { get; }
    public UnityEditor.Build.Reporting.PackedAssets[] packedAssets { get; }
    public UnityEditor.Build.Reporting.ScenesUsingAssets[] scenesUsingAssets { get; }
    public UnityEditor.Build.Reporting.BuildStep[] steps { get; }
    public UnityEditor.Build.Reporting.StrippingInfo strippingInfo { get; }
    public UnityEditor.Build.Reporting.BuildSummary summary { get; }

}

}