using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class TypedUxmlAttributeDescription<T> : UIElements.UxmlAttributeDescription
{
    public T defaultValue { get; set; }
    public string defaultValueAsString { get; }

    protected TypedUxmlAttributeDescription();

    public T GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
