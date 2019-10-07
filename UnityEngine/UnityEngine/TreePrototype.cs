using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class TreePrototype
{
    public float bendFactor { get; set; }
    public GameObject prefab { get; set; }

    public TreePrototype();
    public TreePrototype(TreePrototype other);

    public bool Equals(object obj);
    public int GetHashCode();

}

}
