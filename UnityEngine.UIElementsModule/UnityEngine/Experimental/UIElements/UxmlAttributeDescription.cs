using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class UxmlAttributeDescription
{
    static protected string k_XmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

    public string defaultValueAsString { get; }
    public string name { get; set; }
    public string[] obsoleteNames { get; set; }
    public Experimental.UIElements.UxmlTypeRestriction restriction { get; set; }
    public string type { get; protected set; }
    public string typeNamespace { get; protected set; }
    public Use use { get; set; }

    protected UxmlAttributeDescription();

    protected T GetValueFromBag<T>(Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc, Func<string, T, T> converterFunc, T defaultValue);

    public enum Use
    {
        None = 0,
        Optional = 1,
        Prohibited = 2,
        Required = 3,
    }

}

}
