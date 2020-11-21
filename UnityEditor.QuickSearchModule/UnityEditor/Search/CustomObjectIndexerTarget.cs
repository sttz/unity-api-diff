using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public struct CustomObjectIndexerTarget
{
    public int documentIndex;
    public string id;
    public UnityEditor.SerializedObject serializedObject;
    public Object target;
    public Type targetType;

}

}
