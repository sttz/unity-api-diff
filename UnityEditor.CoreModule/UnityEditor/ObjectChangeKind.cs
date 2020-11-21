using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum ObjectChangeKind : ushort
{
    None = 0,
    ChangeScene = 1,
    CreateGameObjectHierarchy = 2,
    ChangeGameObjectStructureHierarchy = 3,
    ChangeGameObjectStructure = 4,
    ChangeGameObjectParent = 5,
    ChangeGameObjectOrComponentProperties = 6,
    DestroyGameObjectHierarchy = 7,
    CreateAssetObject = 8,
    DestroyAssetObject = 9,
    ChangeAssetObjectProperties = 10,
    UpdatePrefabInstances = 11,
}

}
