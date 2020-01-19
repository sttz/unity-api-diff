using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class SearchWindow : UnityEditor.EditorWindow
{
    static public bool Open<T>(UnityEditor.Experimental.UIElements.GraphView.SearchWindowContext context, T provider);

    public SearchWindow();

}

}
