using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlColorAttributeDescription : UIElements.TypedUxmlAttributeDescription<Color>
{
    public string defaultValueAsString { get; }

    public UxmlColorAttributeDescription();

    public Color GetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);
    public bool TryGetValueFromBag(UIElements.IUxmlAttributes bag, UIElements.CreationContext cc, Color value);

}

}
