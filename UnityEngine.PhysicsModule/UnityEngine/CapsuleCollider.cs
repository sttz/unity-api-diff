using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class CapsuleCollider : Collider
{
    public Vector3 center { get; set; }
    public int direction { get; set; }
    public float height { get; set; }
    public float radius { get; set; }

    public CapsuleCollider();

}

}
