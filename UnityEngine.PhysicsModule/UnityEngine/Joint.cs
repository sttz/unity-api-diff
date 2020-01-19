using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Joint : Component
{
    public Vector3 anchor { get; set; }
    public bool autoConfigureConnectedAnchor { get; set; }
    public Vector3 axis { get; set; }
    public float breakForce { get; set; }
    public float breakTorque { get; set; }
    public Vector3 connectedAnchor { get; set; }
    public Rigidbody connectedBody { get; set; }
    public float connectedMassScale { get; set; }
    public Vector3 currentForce { get; }
    public Vector3 currentTorque { get; }
    public bool enableCollision { get; set; }
    public bool enablePreprocessing { get; set; }
    public float massScale { get; set; }

    public Joint();

}

}
