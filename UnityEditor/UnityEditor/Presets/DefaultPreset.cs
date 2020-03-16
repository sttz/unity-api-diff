using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Presets
{

public struct DefaultPreset
{
    public string m_Filter;
    public UnityEditor.Presets.Preset m_Preset;

    public bool enabled { get; set; }
    public string filter { get; set; }
    public UnityEditor.Presets.Preset preset { get; set; }

    public DefaultPreset(string filter, UnityEditor.Presets.Preset preset);
    public DefaultPreset(string filter, UnityEditor.Presets.Preset preset, bool enabled);

}

}
