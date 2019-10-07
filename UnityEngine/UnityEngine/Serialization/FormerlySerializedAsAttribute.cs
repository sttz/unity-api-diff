using System;
using UnityEngine;

namespace UnityEngine.Serialization
{

public class FormerlySerializedAsAttribute : Attribute
{
    public string oldName { get; }

    public FormerlySerializedAsAttribute(string oldName);

}

}
