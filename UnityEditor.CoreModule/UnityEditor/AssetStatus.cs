using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum AssetStatus
{
    Calculating = -1,
    ClientOnly = 0,
    ServerOnly = 1,
    Unchanged = 2,
    Conflict = 3,
    Same = 4,
    NewVersionAvailable = 5,
    NewLocalVersion = 6,
    RestoredFromTrash = 7,
    Ignored = 8,
    BadState = 9,
}

}
