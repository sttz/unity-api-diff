using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioHighPassFilter : Behaviour
{
    public float cutoffFrequency { get; set; }
    public float highpassResonaceQ { get; set; }
    public float highpassResonanceQ { get; set; }

    public AudioHighPassFilter();

}

}
