using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Rect : IEquatable<Rect>, IFormattable
{
    static public Rect zero { get; }

    static public Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
    static public Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates);
    static public Vector2 PointToNormalized(Rect rectangle, Vector2 point);

    public float bottom { get; }
    public Vector2 center { get; set; }
    public float height { get; set; }
    public float left { get; }
    public Vector2 max { get; set; }
    public Vector2 min { get; set; }
    public Vector2 position { get; set; }
    public float right { get; }
    public Vector2 size { get; set; }
    public float top { get; }
    public float width { get; set; }
    public float x { get; set; }
    public float xMax { get; set; }
    public float xMin { get; set; }
    public float y { get; set; }
    public float yMax { get; set; }
    public float yMin { get; set; }

    public Rect(Rect source);
    public Rect(Vector2 position, Vector2 size);
    public Rect(float x, float y, float width, float height);

    public bool Contains(Vector2 point);
    public bool Contains(Vector3 point);
    public bool Contains(Vector3 point, bool allowInverse);
    public bool Equals(object other);
    public bool Equals(Rect other);
    public int GetHashCode();
    public bool Overlaps(Rect other);
    public bool Overlaps(Rect other, bool allowInverse);
    public void Set(float x, float y, float width, float height);
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
