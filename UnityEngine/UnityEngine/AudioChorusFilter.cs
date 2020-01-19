using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioChorusFilter : Behaviour
{
    public float delay { get; set; }
    public float depth { get; set; }
    public float dryMix { get; set; }
    public float feedback { get; set; }
    public float rate { get; set; }
    public float wetMix1 { get; set; }
    public float wetMix2 { get; set; }
    public float wetMix3 { get; set; }

    public AudioChorusFilter();

}

}
