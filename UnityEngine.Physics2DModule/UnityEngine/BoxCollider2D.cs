using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class BoxCollider2D : Collider2D
{
    public bool autoTiling { get; set; }
    public Vector2 center { get; set; }
    public float edgeRadius { get; set; }
    public Vector2 size { get; set; }

    public BoxCollider2D();

}

}
