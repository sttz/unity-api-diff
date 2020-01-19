using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct LayerMask
{
    static public int GetMask(string[] layerNames);
    static public string LayerToName(int layer);
    static public int NameToLayer(string layerName);

    public int value { get; set; }

}

}
