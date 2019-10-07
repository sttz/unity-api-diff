using System;
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
