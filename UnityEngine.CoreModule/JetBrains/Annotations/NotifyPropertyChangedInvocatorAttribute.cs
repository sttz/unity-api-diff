using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
{
    public string ParameterName { get; }

    public NotifyPropertyChangedInvocatorAttribute();
    public NotifyPropertyChangedInvocatorAttribute(string parameterName);

}

}
