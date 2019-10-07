using System;
using UnityEngine;

namespace UnityEngine
{

public class Joint2D : Behaviour
{
    public Rigidbody2D attachedRigidbody { get; }
    public float breakForce { get; set; }
    public float breakTorque { get; set; }
    public bool collideConnected { get; set; }
    public Rigidbody2D connectedBody { get; set; }
    public bool enableCollision { get; set; }
    public Vector2 reactionForce { get; }
    public float reactionTorque { get; }

    public Joint2D();

    public Vector2 GetReactionForce(float timeStep);
    public float GetReactionTorque(float timeStep);

}

}
