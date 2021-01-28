using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public enum RefreshFlags
{
    None = 0,
    Default = 1,
    StructureChanged = 2,
    DisplayModeChanged = 4,
    ItemsChanged = 8,
    GroupChanged = 16,
}

}
