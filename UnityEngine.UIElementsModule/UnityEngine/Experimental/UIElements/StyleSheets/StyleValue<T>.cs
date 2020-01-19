using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements.StyleSheets
{

public struct StyleValue<T>
{
    static public Experimental.UIElements.StyleSheets.StyleValue<T> nil { get; }

    static public Experimental.UIElements.StyleSheets.StyleValue<T> Create(T value);

    public T value;

    public StyleValue(T value);

    public T GetSpecifiedValueOrDefault(T defaultValue);
    public string ToString();

}

}
