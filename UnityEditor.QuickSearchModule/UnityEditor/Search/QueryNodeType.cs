using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public enum QueryNodeType
{
    And = 0,
    Or = 1,
    Filter = 2,
    Search = 3,
    Not = 4,
    NestedQuery = 5,
    Where = 6,
    FilterIn = 7,
    Union = 8,
    Intersection = 9,
    Aggregator = 10,
}

}
