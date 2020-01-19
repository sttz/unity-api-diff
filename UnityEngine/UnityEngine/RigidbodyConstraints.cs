using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public enum RigidbodyConstraints
{
    None = 0,
    FreezePositionX = 2,
    FreezePositionY = 4,
    FreezePositionZ = 8,
    FreezePosition = 14,
    FreezeRotationX = 16,
    FreezeRotationY = 32,
    FreezeRotationZ = 64,
    FreezeRotation = 112,
    FreezeAll = 126,
}

}
