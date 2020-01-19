using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Color32
{
    static public Color32 Lerp(Color32 a, Color32 b, float t);
    static public Color32 LerpUnclamped(Color32 a, Color32 b, float t);

    public byte a;
    public byte b;
    public byte g;
    public byte r;

    public Color32(byte r, byte g, byte b, byte a);

    public string ToString();
    public string ToString(string format);

}

}
