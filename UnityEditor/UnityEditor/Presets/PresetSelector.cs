using System;
using UnityEngine;

namespace UnityEditor.Presets
{

public class PresetSelector : UnityEditor.EditorWindow
{
    static public bool DrawPresetButton(Rect rectangle, Object[] targets);
    static public void ShowSelector(Object[] targets, UnityEditor.Presets.Preset currentSelection, bool createNewAllowed);
    static public void ShowSelector(Object target, UnityEditor.Presets.Preset currentSelection, bool createNewAllowed, UnityEditor.Presets.PresetSelectorReceiver eventReceiver);
    static public void ShowSelector(UnityEditor.Presets.PresetType presetType, UnityEditor.Presets.Preset currentSelection, bool createNewAllowed, UnityEditor.Presets.PresetSelectorReceiver eventReceiver);

    public PresetSelector();

}

}
