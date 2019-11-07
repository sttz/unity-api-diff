using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class TokenNode : UnityEditor.Experimental.UIElements.GraphView.Node
{
    public bool highlighted { get; set; }
    public Texture icon { get; set; }
    public UnityEditor.Experimental.UIElements.GraphView.Port input { get; }
    public UnityEditor.Experimental.UIElements.GraphView.Port output { get; }

    public TokenNode(UnityEditor.Experimental.UIElements.GraphView.Port input, UnityEditor.Experimental.UIElements.GraphView.Port output);

}

}
