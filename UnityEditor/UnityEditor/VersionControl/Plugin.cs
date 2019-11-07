using System;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class Plugin
{
    static public UnityEditor.VersionControl.Plugin[] availablePlugins { get; }

    public UnityEditor.VersionControl.ConfigField[] configFields { get; }
    public string name { get; }

    public void Dispose();

}

}
