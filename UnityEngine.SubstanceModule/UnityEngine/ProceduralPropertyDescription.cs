using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ProceduralPropertyDescription
{
    public string[] componentLabels;
    public string[] enumOptions;
    public string group;
    public bool hasRange;
    public string label;
    public float maximum;
    public float minimum;
    public string name;
    public float step;
    public ProceduralPropertyType type;

    public ProceduralPropertyDescription();

}

}
