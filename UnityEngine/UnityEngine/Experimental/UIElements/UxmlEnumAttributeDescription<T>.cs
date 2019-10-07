using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlEnumAttributeDescription<T> : Experimental.UIElements.UxmlAttributeDescription
{
    public T defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlEnumAttributeDescription();

    public T GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public T GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
