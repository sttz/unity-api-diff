using System;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshLinkInstance
{
    public Object owner { get; set; }
    public bool valid { get; }

    public void Remove();

}

}
