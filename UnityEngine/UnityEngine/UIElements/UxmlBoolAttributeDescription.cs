using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlBoolAttributeDescription : UIElements.TypedUxmlAttributeDescription<bool>
{
    public string defaultValueAsString { get; }

    public UxmlBoolAttributeDescription();

    public bool GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, bool value);

}

}
