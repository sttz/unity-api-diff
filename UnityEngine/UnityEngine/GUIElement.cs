using System;
using UnityEngine;

namespace UnityEngine
{

public class GUIElement : Behaviour
{
    public GUIElement();

    public Rect GetScreenRect(Camera camera);
    public Rect GetScreenRect();
    public bool HitTest(Vector3 screenPosition);
    public bool HitTest(Vector3 screenPosition, Camera camera);

}

}