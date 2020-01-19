using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshBuildMarkup
{
    public int area { get; set; }
    public bool ignoreFromBuild { get; set; }
    public bool overrideArea { get; set; }
    public Transform root { get; set; }

}

}
