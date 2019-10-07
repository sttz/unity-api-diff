using System;
using UnityEngine;

namespace UnityEngine
{

public struct RectInt : IEquatable<RectInt>
{
    public PositionEnumerator allPositionsWithin { get; }
    public Vector2 center { get; }
    public int height { get; set; }
    public Vector2Int max { get; set; }
    public Vector2Int min { get; set; }
    public Vector2Int position { get; set; }
    public Vector2Int size { get; set; }
    public int width { get; set; }
    public int x { get; set; }
    public int xMax { get; set; }
    public int xMin { get; set; }
    public int y { get; set; }
    public int yMax { get; set; }
    public int yMin { get; set; }

    public RectInt(int xMin, int yMin, int width, int height);
    public RectInt(Vector2Int position, Vector2Int size);

    public void ClampToBounds(RectInt bounds);
    public bool Contains(Vector2Int position);
    public bool Equals(RectInt other);
    public bool Overlaps(RectInt other);
    public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition);
    public string ToString();

    public struct PositionEnumerator : System.Collections.Generic.IEnumerator<Vector2Int>, System.Collections.IEnumerator, IDisposable
    {
        public Vector2Int Current { get; }

        public PositionEnumerator(Vector2Int min, Vector2Int max);

        public PositionEnumerator GetEnumerator();
        public bool MoveNext();
        public void Reset();

    }

}

}
