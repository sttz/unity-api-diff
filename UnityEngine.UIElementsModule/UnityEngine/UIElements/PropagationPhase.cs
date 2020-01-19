using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public enum PropagationPhase
{
    None = 0,
    TrickleDown = 1,
    AtTarget = 2,
    BubbleUp = 3,
    DefaultAction = 4,
}

}
