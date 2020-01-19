using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class MultilineAttribute : PropertyAttribute
{
    public int lines;

    public MultilineAttribute();
    public MultilineAttribute(int lines);

}

}
