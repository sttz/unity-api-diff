using System;
using UnityEngine;

namespace UnityEngine
{

public enum RigidbodyConstraints
{
    None = 0,
    FreezePositionX = 2,
    FreezePositionY = 4,
    FreezePositionZ = 8,
    FreezeRotationX = 16,
    FreezeRotationY = 32,
    FreezeRotationZ = 64,
    FreezePosition = 14,
    FreezeRotation = 112,
    FreezeAll = 126,
}

}
