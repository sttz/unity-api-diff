using System;
using UnityEngine;

namespace UnityEngine
{

public struct Pose : IEquatable<Pose>
{
    static public Pose identity { get; }

    public Vector3 position;
    public Quaternion rotation;

    public Vector3 forward { get; }
    public Vector3 right { get; }
    public Vector3 up { get; }

    public Pose(Vector3 position, Quaternion rotation);

    public bool Equals(object obj);
    public bool Equals(Pose other);
    public int GetHashCode();
    public Pose GetTransformedBy(Pose lhs);
    public Pose GetTransformedBy(Transform lhs);
    public string ToString();
    public string ToString(string format);

}

}
