using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Serialization
{

public class FormerlySerializedAsAttribute : Attribute
{
    public string oldName { get; }

    public FormerlySerializedAsAttribute(string oldName);

}

}
