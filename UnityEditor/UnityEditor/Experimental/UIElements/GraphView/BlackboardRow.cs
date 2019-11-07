using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class BlackboardRow : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public bool expanded { get; set; }

    public BlackboardRow(Experimental.UIElements.VisualElement item, Experimental.UIElements.VisualElement propertyView);

}

}
