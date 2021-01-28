using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class Query<TData, TPayload>
{
    public ICollection<UnityEditor.Search.QueryError> errors { get; }
    public string text { get; }
    public ICollection<string> tokens { get; }
    public bool valid { get; }

    public IEnumerable<TData> Apply(TPayload payload = null);
    public UnityEditor.Search.IQueryNode GetNodeAtPosition(int position);
    public void Optimize(UnityEditor.Search.QueryGraphOptimizationOptions options);
    public void Optimize(bool propagateNotToLeaves, bool swapNotToRightHandSide);

}

}
