using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class TokenNode : UnityEditor.Experimental.GraphView.Node
{
    public bool highlighted { get; set; }
    public Texture icon { get; set; }
    public UnityEditor.Experimental.GraphView.Port input { get; }
    public UnityEditor.Experimental.GraphView.Port output { get; }

    public TokenNode(UnityEditor.Experimental.GraphView.Port input, UnityEditor.Experimental.GraphView.Port output);

}

}
