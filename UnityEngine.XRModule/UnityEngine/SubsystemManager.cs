using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class SubsystemManager
{
    static public event Action reloadSubsytemsCompleted;
    static public event Action reloadSubsytemsStarted;

    static public void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors);
    static public void GetInstances<T>(List<T> instances);
    static public void GetSubsystemDescriptors<T>(List<T> descriptors);

}

}
