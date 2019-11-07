using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class UxmlNamespacePrefixAttribute : Attribute
{
    public string ns { get; }
    public string prefix { get; }

    public UxmlNamespacePrefixAttribute(string ns, string prefix);

}

}
