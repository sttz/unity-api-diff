using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface INestedQueryNode : UnityEditor.Search.IQueryNode
{
    public string associatedFilter { get; }

}

}
