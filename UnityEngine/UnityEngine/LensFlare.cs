using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class LensFlare : Behaviour
{
    public float brightness { get; set; }
    public Color color { get; set; }
    public float fadeSpeed { get; set; }
    public Flare flare { get; set; }

    public LensFlare();

}

}
