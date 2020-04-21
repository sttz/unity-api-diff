using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum MeshUpdateFlags
{
    Default = 0,
    DontValidateIndices = 1,
    DontResetBoneBounds = 2,
    DontNotifyMeshUsers = 4,
    DontRecalculateBounds = 8,
}

}
