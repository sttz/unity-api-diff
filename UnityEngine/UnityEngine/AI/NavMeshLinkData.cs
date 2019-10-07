using System;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshLinkData
{
    public int agentTypeID { get; set; }
    public int area { get; set; }
    public bool bidirectional { get; set; }
    public float costModifier { get; set; }
    public Vector3 endPosition { get; set; }
    public Vector3 startPosition { get; set; }
    public float width { get; set; }

}

}
