using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum SelectionMode
{
    Unfiltered = 0,
    TopLevel = 1,
    Deep = 2,
    ExcludePrefab = 4,
    Editable = 8,
    OnlyUserModifiable = 8,
    Assets = 16,
    DeepAssets = 32,
}

}
