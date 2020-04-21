using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TextAreaAttribute : PropertyAttribute
{
    public int maxLines;
    public int minLines;

    public TextAreaAttribute();
    public TextAreaAttribute(int minLines, int maxLines);

}

}
