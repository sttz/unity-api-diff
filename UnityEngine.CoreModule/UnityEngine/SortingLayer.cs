using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct SortingLayer
{
    static public SortingLayer[] layers { get; }

    static public int GetLayerValueFromID(int id);
    static public int GetLayerValueFromName(string name);
    static public string IDToName(int id);
    static public bool IsValid(int id);
    static public int NameToID(string name);

    public int id { get; }
    public string name { get; }
    public int value { get; }

}

}
