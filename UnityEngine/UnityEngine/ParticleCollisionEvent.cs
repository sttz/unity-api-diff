using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct ParticleCollisionEvent
{
    public Component collider { get; }
    public Component colliderComponent { get; }
    public Vector3 intersection { get; }
    public Vector3 normal { get; }
    public Vector3 velocity { get; }

}

}
