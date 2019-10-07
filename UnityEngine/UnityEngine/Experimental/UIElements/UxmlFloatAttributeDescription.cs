using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlFloatAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public float defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlFloatAttributeDescription();

    public float GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public float GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
