using System;
using UnityEngine;

namespace UnityEditor
{

public enum BoneState
{
    None = 0,
    NotFound = 1,
    Duplicate = 2,
    InvalidHierarchy = 3,
    BoneLenghtIsZero = 4,
    Valid = 5,
}

}
