using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface ISearchWindowProvider
{
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.SearchTreeEntry> CreateSearchTree(UnityEditor.Experimental.UIElements.GraphView.SearchWindowContext context);
    public bool OnSelectEntry(UnityEditor.Experimental.UIElements.GraphView.SearchTreeEntry SearchTreeEntry, UnityEditor.Experimental.UIElements.GraphView.SearchWindowContext context);

}

}
