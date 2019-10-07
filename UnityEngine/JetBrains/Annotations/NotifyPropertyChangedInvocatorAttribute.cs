using System;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
{
    public string ParameterName { get; private set; }

    public NotifyPropertyChangedInvocatorAttribute();
    public NotifyPropertyChangedInvocatorAttribute(string parameterName);

}

}
