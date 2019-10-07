using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public enum PropagationPhase
{
    None = 0,
    TrickleDown = 1,
    AtTarget = 2,
    DefaultActionAtTarget = 5,
    BubbleUp = 3,
    DefaultAction = 4,
}

}
