using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class GUIElement
{
    public GUIElement();

    public Rect GetScreenRect(Camera camera);
    public Rect GetScreenRect();
    public bool HitTest(Vector3 screenPosition);
    public bool HitTest(Vector3 screenPosition, Camera camera);

}

}