using System;
using UnityEngine;

namespace UnityEngine
{

public static class SubsystemManager
{
    static public event Action reloadSubsytemsCompleted;
    static public event Action reloadSubsytemsStarted;

    static public void GetAllSubsystemDescriptors(System.Collections.Generic.List<ISubsystemDescriptor> descriptors);
    static public void GetInstances(System.Collections.Generic.List<T> instances);
    static public void GetSubsystemDescriptors(System.Collections.Generic.List<T> descriptors);

}

}