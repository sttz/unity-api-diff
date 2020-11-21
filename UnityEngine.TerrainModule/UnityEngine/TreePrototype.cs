using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TreePrototype
{
    public float bendFactor { get; set; }
    public int navMeshLod { get; set; }
    public GameObject prefab { get; set; }

    public TreePrototype();
    public TreePrototype(TreePrototype other);

    public bool Equals(object obj);
    public int GetHashCode();

}

}
