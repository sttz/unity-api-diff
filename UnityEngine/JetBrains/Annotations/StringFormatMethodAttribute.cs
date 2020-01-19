using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class StringFormatMethodAttribute : Attribute
{
    public string FormatParameterName { get; private set; }

    public StringFormatMethodAttribute(string formatParameterName);

}

}
