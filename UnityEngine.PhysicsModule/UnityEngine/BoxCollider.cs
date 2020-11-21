using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class BoxCollider : Collider
{
    public Vector3 center { get; set; }
    public Vector3 extents { get; set; }
    public Vector3 size { get; set; }

    public BoxCollider();

}

}
