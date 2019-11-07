using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class DrawGizmo : Attribute
{
    public Type drawnType;
    public UnityEditor.GizmoType drawOptions;

    public DrawGizmo(UnityEditor.GizmoType gizmo);
    public DrawGizmo(UnityEditor.GizmoType gizmo, Type drawnGizmoType);

}

}
