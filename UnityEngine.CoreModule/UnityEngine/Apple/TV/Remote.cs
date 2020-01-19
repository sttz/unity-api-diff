using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Apple.TV
{

public sealed class Remote
{
    static public bool allowExitToHome { get; set; }
    static public bool allowRemoteRotation { get; set; }
    static public bool reportAbsoluteDpadValues { get; set; }
    static public bool touchesEnabled { get; set; }

    public Remote();

}

}
