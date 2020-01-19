using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlStringAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public string defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlStringAttributeDescription();

    public string GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public string GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
