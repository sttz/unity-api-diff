using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Attacher
{
    public SpriteAlignment alignment { get; set; }
    public float distance { get; set; }
    public UIElements.VisualElement element { get; private set; }
    public Vector2 offset { get; set; }
    public UIElements.VisualElement target { get; private set; }

    public Attacher(UIElements.VisualElement anchored, UIElements.VisualElement target, SpriteAlignment alignment);

    public void Detach();
    public void Reattach();

}

}
