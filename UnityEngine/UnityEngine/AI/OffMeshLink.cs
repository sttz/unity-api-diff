using System;
using UnityEngine;

namespace UnityEngine.AI
{

public sealed class OffMeshLink : Behaviour
{
    public bool activated { get; set; }
    public int area { get; set; }
    public bool autoUpdatePositions { get; set; }
    public bool biDirectional { get; set; }
    public float costOverride { get; set; }
    public Transform endTransform { get; set; }
    public int navMeshLayer { get; set; }
    public bool occupied { get; }
    public Transform startTransform { get; set; }

    public OffMeshLink();

    public void UpdatePositions();

}

}
