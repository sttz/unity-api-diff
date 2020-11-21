using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public enum CollisionFlags
{
    None = 0,
    Sides = 1,
    CollidedSides = 1,
    Above = 2,
    CollidedAbove = 2,
    Below = 4,
    CollidedBelow = 4,
}

}
