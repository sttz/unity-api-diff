using System;
using UnityEngine;

namespace UnityEditor
{

public enum GizmoType
{
    Pickable = 1,
    NotInSelectionHierarchy = 2,
    NonSelected = 32,
    Selected = 4,
    Active = 8,
    InSelectionHierarchy = 16,
    NotSelected = -127,
    SelectedOrChild = -127,
}

}
