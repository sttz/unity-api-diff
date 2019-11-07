using System;
using UnityEngine;

namespace UnityEditorInternal
{

public enum MemoryInfoGCReason
{
    SceneObject = 0,
    BuiltinResource = 1,
    MarkedDontSave = 2,
    AssetMarkedDirtyInEditor = 3,
    SceneAssetReferencedByNativeCodeOnly = 5,
    SceneAssetReferenced = 6,
    AssetReferencedByNativeCodeOnly = 8,
    AssetReferenced = 9,
    NotApplicable = 10,
}

}
