using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUILayer : Behaviour
{
    public GUILayer();

    public GUIElement HitTest(Vector3 screenPosition);

}

}
