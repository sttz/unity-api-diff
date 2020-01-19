using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlIntAttributeDescription : Experimental.UIElements.UxmlAttributeDescription
{
    public int defaultValue { get; set; }
    public string defaultValueAsString { get; }

    public UxmlIntAttributeDescription();

    public int GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag);
    public int GetValueFromBag(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

}

}
