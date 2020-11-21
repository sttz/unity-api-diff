using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlEnumAttributeDescription<T> : UIElements.TypedUxmlAttributeDescription<T>
{
    public string defaultValueAsString { get; }

    public UxmlEnumAttributeDescription();

    public T GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, T value);

}

}
