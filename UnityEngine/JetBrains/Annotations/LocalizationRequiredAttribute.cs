using System;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class LocalizationRequiredAttribute : Attribute
{
    public bool Required { get; private set; }

    public LocalizationRequiredAttribute();
    public LocalizationRequiredAttribute(bool required);

}

}
