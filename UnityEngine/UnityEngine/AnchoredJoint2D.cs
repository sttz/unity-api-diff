using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class AnchoredJoint2D : Joint2D
{
    public Vector2 anchor { get; set; }
    public bool autoConfigureConnectedAnchor { get; set; }
    public Vector2 connectedAnchor { get; set; }

    public AnchoredJoint2D();

}

}
