using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SearchService
{

public class ObjectSelectorHandlerWithLabelsAttribute : Attribute
{
    public string[] labels { get; }
    public bool matchAll { get; }

    public ObjectSelectorHandlerWithLabelsAttribute(string[] labels);
    public ObjectSelectorHandlerWithLabelsAttribute(bool matchAll, string[] labels);

}

}
