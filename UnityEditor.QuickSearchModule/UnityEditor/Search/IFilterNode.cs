using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface IFilterNode : UnityEditor.Search.IQueryNode
{
    public string filterId { get; }
    public string filterValue { get; }
    public string operatorId { get; }
    public string paramValue { get; }

}

}
