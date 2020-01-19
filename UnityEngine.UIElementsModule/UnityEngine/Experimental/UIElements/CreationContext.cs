using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public struct CreationContext
{
    static public Experimental.UIElements.CreationContext Default;

    public Dictionary<string, Experimental.UIElements.VisualElement> slotInsertionPoints { get; private set; }
    public Experimental.UIElements.VisualElement target { get; private set; }
    public Experimental.UIElements.VisualTreeAsset visualTreeAsset { get; private set; }

}

}
