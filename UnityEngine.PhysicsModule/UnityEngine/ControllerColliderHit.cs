using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class ControllerColliderHit
{
    public Collider collider { get; }
    public CharacterController controller { get; }
    public GameObject gameObject { get; }
    public Vector3 moveDirection { get; }
    public float moveLength { get; }
    public Vector3 normal { get; }
    public Vector3 point { get; }
    public Rigidbody rigidbody { get; }
    public Transform transform { get; }

    public ControllerColliderHit();

}

}
