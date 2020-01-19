using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public enum ParticleSystemSubEmitterProperties
{
    InheritNothing = 0,
    InheritColor = 1,
    InheritSize = 2,
    InheritRotation = 4,
    InheritLifetime = 8,
    InheritDuration = 16,
    InheritEverything = 31,
}

}
