using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class CustomObjectIndexerAttribute : Attribute
{
    public Type type { get; }
    public int version { get; set; }

    public CustomObjectIndexerAttribute(Type type);

}

}
