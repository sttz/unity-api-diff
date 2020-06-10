using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public enum TransitionInterruptionSource
{
    None = 0,
    Source = 1,
    Destination = 2,
    SourceThenDestination = 3,
    DestinationThenSource = 4,
}

}
