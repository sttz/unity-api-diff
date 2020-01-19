using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum PrefabType
{
    None = 0,
    Prefab = 1,
    ModelPrefab = 2,
    PrefabInstance = 3,
    ModelPrefabInstance = 4,
    MissingPrefabInstance = 5,
    DisconnectedPrefabInstance = 6,
    DisconnectedModelPrefabInstance = 7,
}

}
