using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Resizer : UIElements.VisualElement
{
    public UIElements.MouseButton activateButton { get; set; }

    public Resizer();
    public Resizer(Action onResizedCallback);
    public Resizer(Vector2 minimumSize, Action onResizedCallback = null);

}

}
