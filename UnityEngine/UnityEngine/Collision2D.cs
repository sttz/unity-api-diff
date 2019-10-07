using System;
using UnityEngine;

namespace UnityEngine
{

public class Collision2D
{
    public Collider2D collider { get; }
    public int contactCount { get; }
    public ContactPoint2D[] contacts { get; }
    public bool enabled { get; }
    public GameObject gameObject { get; }
    public Collider2D otherCollider { get; }
    public Rigidbody2D otherRigidbody { get; }
    public Vector2 relativeVelocity { get; }
    public Rigidbody2D rigidbody { get; }
    public Transform transform { get; }

    public Collision2D();

    public ContactPoint2D GetContact(int index);
    public int GetContacts(ContactPoint2D[] contacts);
    public int GetContacts(System.Collections.Generic.List<ContactPoint2D> contacts);

}

}
