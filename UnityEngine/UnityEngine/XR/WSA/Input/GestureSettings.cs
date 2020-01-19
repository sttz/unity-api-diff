using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public enum GestureSettings
{
    None = 0,
    Tap = 1,
    DoubleTap = 2,
    Hold = 4,
    ManipulationTranslate = 8,
    NavigationX = 16,
    NavigationY = 32,
    NavigationZ = 64,
    NavigationRailsX = 128,
    NavigationRailsY = 256,
    NavigationRailsZ = 512,
}

}
