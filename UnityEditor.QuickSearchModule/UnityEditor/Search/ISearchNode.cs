using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface ISearchNode : UnityEditor.Search.IQueryNode
{
    public bool exact { get; }
    public string searchValue { get; }

}

}
