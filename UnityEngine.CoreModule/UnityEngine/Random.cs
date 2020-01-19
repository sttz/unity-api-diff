using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Random
{
    static public Vector2 insideUnitCircle { get; }
    static public Vector3 insideUnitSphere { get; }
    static public Vector3 onUnitSphere { get; }
    static public Quaternion rotation { get; }
    static public Quaternion rotationUniform { get; }
    static public int seed { get; set; }
    static public State state { get; set; }
    static public float value { get; }

    static public Color ColorHSV();
    static public Color ColorHSV(float hueMin, float hueMax);
    static public Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax);
    static public Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax);
    static public Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax);
    static public void InitState(int seed);
    static public int RandomRange(int min, int max);
    static public float RandomRange(float min, float max);
    static public int Range(int min, int max);
    static public float Range(float min, float max);

    public Random();

    public struct State
    {
    }

}

}
