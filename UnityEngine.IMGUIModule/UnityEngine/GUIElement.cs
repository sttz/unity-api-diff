using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GUIElement
{
    public GUIElement();

    public Rect GetScreenRect();
    public Rect GetScreenRect(Camera camera);
    public bool HitTest(Vector3 screenPosition);
    public bool HitTest(Vector3 screenPosition, Camera camera);

}

}
