using System;
using UnityEngine;

namespace UnityEngine
{

public class GUILayer : Behaviour
{
    public GUILayer();

    public GUIElement HitTest(Vector3 screenPosition);

}

}
