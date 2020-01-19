using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class UxmlTraits
{
    public bool canHaveAnyAttribute { get; protected set; }
    public IEnumerable<UIElements.UxmlAttributeDescription> uxmlAttributesDescription { get; }
    public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    protected UxmlTraits();

    public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
