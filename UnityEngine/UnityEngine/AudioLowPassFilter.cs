using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioLowPassFilter : Behaviour
{
    public AnimationCurve customCutoffCurve { get; set; }
    public float cutoffFrequency { get; set; }
    public float lowpassResonaceQ { get; set; }
    public float lowpassResonanceQ { get; set; }

    public AudioLowPassFilter();

}

}
