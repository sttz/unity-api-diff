using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface ISearchWindowProvider
{
    public List<UnityEditor.Experimental.GraphView.SearchTreeEntry> CreateSearchTree(UnityEditor.Experimental.GraphView.SearchWindowContext context);
    public bool OnSelectEntry(UnityEditor.Experimental.GraphView.SearchTreeEntry SearchTreeEntry, UnityEditor.Experimental.GraphView.SearchWindowContext context);

}

}
