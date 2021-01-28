using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public struct QueryGraphOptimizationOptions
{
    public bool propagateNotToLeaves;
    public bool swapFilterFunctionsToRightHandSide;
    public bool swapNotToRightHandSide;

}

}
