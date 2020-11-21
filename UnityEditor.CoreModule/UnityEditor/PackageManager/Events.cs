using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public static class Events
{
    static public event Action<UnityEditor.PackageManager.PackageRegistrationEventArgs> registeredPackages;
    static public event Action<UnityEditor.PackageManager.PackageRegistrationEventArgs> registeringPackages;

}

}
