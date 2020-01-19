using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AI
{

public struct OffMeshLinkData
{
    public bool activated { get; }
    public Vector3 endPos { get; }
    public AI.OffMeshLinkType linkType { get; }
    public AI.OffMeshLink offMeshLink { get; }
    public Vector3 startPos { get; }
    public bool valid { get; }

}

}
