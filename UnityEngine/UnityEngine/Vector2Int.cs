using System;
using UnityEngine;

namespace UnityEngine
{

public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
    static public Vector2Int down { get; }
    static public Vector2Int left { get; }
    static public Vector2Int one { get; }
    static public Vector2Int right { get; }
    static public Vector2Int up { get; }
    static public Vector2Int zero { get; }

    static public Vector2Int CeilToInt(Vector2 v);
    static public float Distance(Vector2Int a, Vector2Int b);
    static public Vector2Int FloorToInt(Vector2 v);
    static public Vector2Int Max(Vector2Int lhs, Vector2Int rhs);
    static public Vector2Int Min(Vector2Int lhs, Vector2Int rhs);
    static public Vector2Int RoundToInt(Vector2 v);
    static public Vector2Int Scale(Vector2Int a, Vector2Int b);

    public int this[int index] { get; set; }
    public float magnitude { get; }
    public int sqrMagnitude { get; }
    public int x { get; set; }
    public int y { get; set; }

    public Vector2Int(int x, int y);

    public void Clamp(Vector2Int min, Vector2Int max);
    public bool Equals(object other);
    public bool Equals(Vector2Int other);
    public int GetHashCode();
    public void Scale(Vector2Int scale);
    public void Set(int x, int y);
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
