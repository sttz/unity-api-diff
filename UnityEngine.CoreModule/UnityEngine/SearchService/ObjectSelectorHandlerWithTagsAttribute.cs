using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SearchService
{

public class ObjectSelectorHandlerWithTagsAttribute : Attribute
{
    public string[] tags { get; }

    public ObjectSelectorHandlerWithTagsAttribute(string[] tags);

}

}
