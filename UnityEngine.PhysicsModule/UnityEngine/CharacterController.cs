using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class CharacterController : Collider
{
    public Vector3 center { get; set; }
    public CollisionFlags collisionFlags { get; }
    public bool detectCollisions { get; set; }
    public bool enableOverlapRecovery { get; set; }
    public float height { get; set; }
    public bool isGrounded { get; }
    public float minMoveDistance { get; set; }
    public float radius { get; set; }
    public float skinWidth { get; set; }
    public float slopeLimit { get; set; }
    public float stepOffset { get; set; }
    public Vector3 velocity { get; }

    public CharacterController();

    public CollisionFlags Move(Vector3 motion);
    public bool SimpleMove(Vector3 speed);

}

}
