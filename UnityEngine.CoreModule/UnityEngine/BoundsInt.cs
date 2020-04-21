using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
{
    public PositionEnumerator allPositionsWithin { get; }
    public Vector3 center { get; }
    public Vector3Int max { get; set; }
    public Vector3Int min { get; set; }
    public Vector3Int position { get; set; }
    public Vector3Int size { get; set; }
    public int x { get; set; }
    public int xMax { get; set; }
    public int xMin { get; set; }
    public int y { get; set; }
    public int yMax { get; set; }
    public int yMin { get; set; }
    public int z { get; set; }
    public int zMax { get; set; }
    public int zMin { get; set; }

    public BoundsInt(Vector3Int position, Vector3Int size);
    public BoundsInt(int xMin, int yMin, int zMin, int sizeX, int sizeY, int sizeZ);

    public void ClampToBounds(BoundsInt bounds);
    public bool Contains(Vector3Int position);
    public bool Equals(object other);
    public bool Equals(BoundsInt other);
    public int GetHashCode();
    public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition);
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

    public struct PositionEnumerator : IEnumerator<Vector3Int>, IEnumerator, IDisposable
    {
        public Vector3Int Current { get; }

        public PositionEnumerator(Vector3Int min, Vector3Int max);

        public PositionEnumerator GetEnumerator();
        public bool MoveNext();
        public void Reset();

    }

}

}
