using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class FocusChangeDirection : IDisposable
{
    static protected UIElements.FocusChangeDirection lastValue { get; }
    static public UIElements.FocusChangeDirection none { get; }
    static public UIElements.FocusChangeDirection unspecified { get; }

    protected FocusChangeDirection(int value);

    protected void Dispose();

}

}
