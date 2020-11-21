using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Time
{
    static public float captureDeltaTime { get; set; }
    static public int captureFramerate { get; set; }
    static public float deltaTime { get; }
    static public float fixedDeltaTime { get; set; }
    static public float fixedTime { get; }
    static public double fixedTimeAsDouble { get; }
    static public float fixedUnscaledDeltaTime { get; }
    static public float fixedUnscaledTime { get; }
    static public double fixedUnscaledTimeAsDouble { get; }
    static public int frameCount { get; }
    static public bool inFixedTimeStep { get; }
    static public float maximumDeltaTime { get; set; }
    static public float maximumParticleDeltaTime { get; set; }
    static public float realtimeSinceStartup { get; }
    static public double realtimeSinceStartupAsDouble { get; }
    static public int renderedFrameCount { get; }
    static public float smoothDeltaTime { get; }
    static public float time { get; }
    static public double timeAsDouble { get; }
    static public float timeScale { get; set; }
    static public float timeSinceLevelLoad { get; }
    static public double timeSinceLevelLoadAsDouble { get; }
    static public float unscaledDeltaTime { get; }
    static public float unscaledTime { get; }
    static public double unscaledTimeAsDouble { get; }

    public Time();

}

}
