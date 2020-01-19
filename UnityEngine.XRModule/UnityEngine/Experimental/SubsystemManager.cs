using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public static class SubsystemManager
{
    static public void GetInstances<T>(List<T> instances);
    static public void GetSubsystemDescriptors<T>(List<T> descriptors);

}

}
