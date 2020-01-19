using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface ISearchWindowProvider
{
    public List<UnityEditor.Experimental.UIElements.GraphView.SearchTreeEntry> CreateSearchTree(UnityEditor.Experimental.UIElements.GraphView.SearchWindowContext context);
    public bool OnSelectEntry(UnityEditor.Experimental.UIElements.GraphView.SearchTreeEntry SearchTreeEntry, UnityEditor.Experimental.UIElements.GraphView.SearchWindowContext context);

}

}
