using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum GizmoType
{
    NotSelected = -127,
    SelectedOrChild = -127,
    Pickable = 1,
    NotInSelectionHierarchy = 2,
    Selected = 4,
    Active = 8,
    InSelectionHierarchy = 16,
    NonSelected = 32,
}

}
