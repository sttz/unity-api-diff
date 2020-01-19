using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Vector3Int : IEquatable<Vector3Int>
{
    static public Vector3Int down { get; }
    static public Vector3Int left { get; }
    static public Vector3Int one { get; }
    static public Vector3Int right { get; }
    static public Vector3Int up { get; }
    static public Vector3Int zero { get; }

    static public Vector3Int CeilToInt(Vector3 v);
    static public float Distance(Vector3Int a, Vector3Int b);
    static public Vector3Int FloorToInt(Vector3 v);
    static public Vector3Int Max(Vector3Int lhs, Vector3Int rhs);
    static public Vector3Int Min(Vector3Int lhs, Vector3Int rhs);
    static public Vector3Int RoundToInt(Vector3 v);
    static public Vector3Int Scale(Vector3Int a, Vector3Int b);

    public int this[int index] { get; set; }
    public float magnitude { get; }
    public int sqrMagnitude { get; }
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public Vector3Int(int x, int y, int z);

    public void Clamp(Vector3Int min, Vector3Int max);
    public bool Equals(object other);
    public bool Equals(Vector3Int other);
    public int GetHashCode();
    public void Scale(Vector3Int scale);
    public void Set(int x, int y, int z);
    public string ToString();
    public string ToString(string format);

}

}
