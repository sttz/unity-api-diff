using System;
using UnityEngine;

namespace UnityEngine
{

public class Collision
{
    public Collider collider { get; }
    public int contactCount { get; }
    public ContactPoint[] contacts { get; }
    public Vector3 frictionForceSum { get; }
    public GameObject gameObject { get; }
    public Vector3 impactForceSum { get; }
    public Vector3 impulse { get; }
    public Component other { get; }
    public Vector3 relativeVelocity { get; }
    public Rigidbody rigidbody { get; }
    public Transform transform { get; }

    public Collision();

    public ContactPoint GetContact(int index);
    public int GetContacts(ContactPoint[] contacts);
    public System.Collections.IEnumerator GetEnumerator();

}

}
