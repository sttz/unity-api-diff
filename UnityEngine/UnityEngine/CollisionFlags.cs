using System;
using UnityEngine;

namespace UnityEngine
{

public enum CollisionFlags
{
    None = 0,
    Sides = 1,
    Above = 2,
    Below = 4,
    CollidedSides = 1,
    CollidedAbove = 2,
    CollidedBelow = 4,
}

}
