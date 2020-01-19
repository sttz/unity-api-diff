using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public class SplashScreen
{
    static public bool isFinished { get; }

    static public void Begin();
    static public void Draw();
    static public void Stop(StopBehavior stopBehavior);

    public SplashScreen();

    public enum StopBehavior
    {
        StopImmediate = 0,
        FadeOut = 1,
    }

}

}
