using System;
using UnityEngine;

namespace UnityEditor.Presets
{

public abstract class PresetSelectorReceiver : ScriptableObject
{
    protected PresetSelectorReceiver();

    public void OnSelectionChanged(UnityEditor.Presets.Preset selection);
    public void OnSelectionClosed(UnityEditor.Presets.Preset selection);

}

}
