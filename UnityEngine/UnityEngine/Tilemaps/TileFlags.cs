using System;
using UnityEngine;

namespace UnityEngine.Tilemaps
{

public enum TileFlags
{
    None = 0,
    LockColor = 1,
    LockTransform = 2,
    InstantiateGameObjectRuntimeOnly = 4,
    LockAll = 3,
}

}
