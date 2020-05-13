using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class AssertionConditionAttribute : Attribute
{
    public JetBrains.Annotations.AssertionConditionType ConditionType { get; }

    public AssertionConditionAttribute(JetBrains.Annotations.AssertionConditionType conditionType);

}

}
