using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshQueryFilter
{
    public int agentTypeID { get; set; }
    public int areaMask { get; set; }

    public float GetAreaCost(int areaIndex);
    public void SetAreaCost(int areaIndex, float cost);

}

}
