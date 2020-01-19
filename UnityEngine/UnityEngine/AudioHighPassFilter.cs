using System;
using System.Collections;
using System.Collections.Generic;
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
