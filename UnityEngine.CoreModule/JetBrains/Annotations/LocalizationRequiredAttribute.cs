using System;
using System.Collections;
using System.Collections.Generic;
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