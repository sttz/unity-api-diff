using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class BlackboardRow : UnityEditor.Experimental.GraphView.GraphElement
{
    public bool expanded { get; set; }

    public BlackboardRow(UIElements.VisualElement item, UIElements.VisualElement propertyView);

}

}
