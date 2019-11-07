using System;
using UnityEngine;

namespace UnityEditor.Rendering
{

public sealed class EditorGraphicsSettings
{
    static public UnityEditor.Rendering.AlbedoSwatchInfo[] albedoSwatches { get; set; }

    static public UnityEditor.Rendering.PlatformShaderSettings GetShaderSettingsForPlatform(UnityEditor.BuildTargetGroup target, Rendering.ShaderHardwareTier tier);
    static public UnityEditor.Rendering.TierSettings GetTierSettings(UnityEditor.BuildTargetGroup target, Rendering.GraphicsTier tier);
    static public UnityEditor.Rendering.TierSettings GetTierSettings(UnityEditor.BuildTargetGroup target, Rendering.ShaderHardwareTier tier);
    static public void SetShaderSettingsForPlatform(UnityEditor.BuildTargetGroup target, Rendering.ShaderHardwareTier tier, UnityEditor.Rendering.PlatformShaderSettings settings);
    static public void SetTierSettings(UnityEditor.BuildTargetGroup target, Rendering.GraphicsTier tier, UnityEditor.Rendering.TierSettings settings);
    static public void SetTierSettings(UnityEditor.BuildTargetGroup target, Rendering.ShaderHardwareTier tier, UnityEditor.Rendering.TierSettings settings);

    public EditorGraphicsSettings();

}

}
