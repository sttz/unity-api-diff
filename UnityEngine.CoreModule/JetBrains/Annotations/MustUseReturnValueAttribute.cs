using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class MustUseReturnValueAttribute : Attribute
{
    public string Justification { get; }

    public MustUseReturnValueAttribute();
    public MustUseReturnValueAttribute(string justification);

}

}
