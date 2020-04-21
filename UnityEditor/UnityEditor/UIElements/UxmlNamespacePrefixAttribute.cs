using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public sealed class UxmlNamespacePrefixAttribute : Attribute
{
    public string ns { get; }
    public string prefix { get; }

    public UxmlNamespacePrefixAttribute(string ns, string prefix);

}

}
