using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface IQueryNode
{
    public List<UnityEditor.Search.IQueryNode> children { get; }
    public string identifier { get; }
    public bool leaf { get; }
    public UnityEditor.Search.IQueryNode parent { get; set; }
    public bool skipped { get; set; }
    public UnityEditor.Search.QueryToken token { get; set; }
    public UnityEditor.Search.QueryNodeType type { get; }

    public int QueryHashCode();

}

}
