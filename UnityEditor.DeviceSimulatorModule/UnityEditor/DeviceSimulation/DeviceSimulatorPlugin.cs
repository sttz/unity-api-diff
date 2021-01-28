using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.DeviceSimulation
{

public abstract class DeviceSimulatorPlugin
{
    public UnityEditor.DeviceSimulation.DeviceSimulator deviceSimulator { get; internal set; }
    public string title { get; }

    protected DeviceSimulatorPlugin();

    public void OnCreate();
    public UIElements.VisualElement OnCreateUI();
    public void OnDestroy();

}

}
