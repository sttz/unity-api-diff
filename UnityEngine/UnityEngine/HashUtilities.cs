using System;
using UnityEngine;

namespace UnityEngine
{

public static class HashUtilities
{
    static public void AppendHash(Hash128 inHash, Hash128 outHash);
    static public void ComputeHash128(T& value, Hash128 hash);
    static public void QuantisedMatrixHash(Matrix4x4 value, Hash128 hash);
    static public void QuantisedVectorHash(Vector3 value, Hash128 hash);

}

}
