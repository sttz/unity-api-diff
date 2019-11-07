using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
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
