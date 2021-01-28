using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class QueryGraph
{
    public bool empty { get; }
    public UnityEditor.Search.IQueryNode root { get; private set; }

    public QueryGraph(UnityEditor.Search.IQueryNode root);

    public void Optimize(UnityEditor.Search.QueryGraphOptimizationOptions options);
    public void Optimize(bool propagateNotToLeaves, bool swapNotToRightHandSide);

}

}
