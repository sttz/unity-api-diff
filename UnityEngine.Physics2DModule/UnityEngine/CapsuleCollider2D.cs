using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class CapsuleCollider2D : Collider2D
{
    public CapsuleDirection2D direction { get; set; }
    public Vector2 size { get; set; }

    public CapsuleCollider2D();

}

}
