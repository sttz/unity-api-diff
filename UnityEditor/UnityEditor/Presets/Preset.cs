using System;
using UnityEngine;

namespace UnityEditor.Presets
{

public sealed class Preset : Object
{
    static public UnityEditor.Presets.Preset GetDefaultForObject(Object target);
    static public UnityEditor.Presets.Preset GetDefaultForPreset(UnityEditor.Presets.Preset preset);
    static public UnityEditor.Presets.Preset[] GetDefaultPresetsForObject(Object target);
    static public UnityEditor.Presets.DefaultPreset[] GetDefaultPresetsForType(UnityEditor.Presets.PresetType type);
    static public bool IsObjectExcludedFromDefaultPresets(Object target);
    static public bool IsObjectExcludedFromPresets(Object target);
    static public bool IsPresetExcludedFromDefaultPresets(UnityEditor.Presets.Preset preset);
    static public void RemoveFromDefault(UnityEditor.Presets.Preset preset);
    static public bool SetAsDefault(UnityEditor.Presets.Preset preset);
    static public bool SetDefaultPresetsForType(UnityEditor.Presets.PresetType type, UnityEditor.Presets.DefaultPreset[] presets);

    public UnityEditor.PropertyModification[] PropertyModifications { get; }

    public Preset(Object source);

    public bool ApplyTo(Object target);
    public bool ApplyTo(Object target, string[] selectedPropertyPaths);
    public bool CanBeAppliedTo(Object target);
    public bool DataEquals(Object target);
    public UnityEditor.Presets.PresetType GetPresetType();
    public string GetTargetFullTypeName();
    public string GetTargetTypeName();
    public bool IsValid();
    public bool UpdateProperties(Object source);

}

}
