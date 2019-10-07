using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public enum PropagationPhase
{
    None = 0,
    TrickleDown = 1,
    Capture = 1,
    AtTarget = 2,
    BubbleUp = 3,
    DefaultAction = 4,
}

}
