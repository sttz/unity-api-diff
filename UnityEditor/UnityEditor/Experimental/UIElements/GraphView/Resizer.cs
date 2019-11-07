using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Resizer : Experimental.UIElements.VisualElement
{
    public Experimental.UIElements.MouseButton activateButton { get; set; }

    public Resizer();
    public Resizer(Vector2 minimumSize);

}

}
