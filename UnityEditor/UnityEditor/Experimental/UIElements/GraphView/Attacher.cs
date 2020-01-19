using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Attacher
{
    public SpriteAlignment alignment { get; set; }
    public float distance { get; set; }
    public Experimental.UIElements.VisualElement element { get; private set; }
    public Vector2 offset { get; set; }
    public Experimental.UIElements.VisualElement target { get; private set; }

    public Attacher(Experimental.UIElements.VisualElement anchored, Experimental.UIElements.VisualElement target, SpriteAlignment alignment);

    public void Detach();
    public void Reattach();

}

}
