using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class LocalizationRequiredAttribute : Attribute
{
    public bool Required { get; }

    public LocalizationRequiredAttribute();
    public LocalizationRequiredAttribute(bool required);

}

}
