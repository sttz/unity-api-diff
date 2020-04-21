using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class IAudioEffectPluginGUI
{
    public string Description { get; }
    public string Name { get; }
    public string Vendor { get; }

    protected IAudioEffectPluginGUI();

    public bool OnGUI(UnityEditor.IAudioEffectPlugin plugin);

}

}
