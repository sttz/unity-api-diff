using System;
using UnityEngine;

namespace UnityEditor.Presets
{

public class DefaultPresetSelectorReceiver : UnityEditor.Presets.PresetSelectorReceiver
{
    public DefaultPresetSelectorReceiver();

    public void OnSelectionChanged(UnityEditor.Presets.Preset selection);
    public void OnSelectionClosed(UnityEditor.Presets.Preset selection);

}

}
