using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlIntAttributeDescription : UIElements.TypedUxmlAttributeDescription<int>
{
    public string defaultValueAsString { get; }

    public UxmlIntAttributeDescription();

    public int GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, int value);

}

}
