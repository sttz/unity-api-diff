using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlTypeAttributeDescription<TBase> : UIElements.TypedUxmlAttributeDescription<Type>
{
    public string defaultValueAsString { get; }

    public UxmlTypeAttributeDescription();

    public Type GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, Type value);

}

}
