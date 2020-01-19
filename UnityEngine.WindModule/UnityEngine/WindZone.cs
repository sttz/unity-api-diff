using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class WindZone : Component
{
    public WindZoneMode mode { get; set; }
    public float radius { get; set; }
    public float windMain { get; set; }
    public float windPulseFrequency { get; set; }
    public float windPulseMagnitude { get; set; }
    public float windTurbulence { get; set; }

    public WindZone();

}

}
