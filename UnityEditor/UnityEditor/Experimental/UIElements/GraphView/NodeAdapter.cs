using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class NodeAdapter
{
    public NodeAdapter();

    public bool CanAdapt(object a, object b);
    public bool Connect(object a, object b);
    public System.Reflection.MethodInfo GetAdapter(object a, object b);
    public System.Reflection.MethodInfo GetTypeAdapter(Type from, Type to);

}

}
