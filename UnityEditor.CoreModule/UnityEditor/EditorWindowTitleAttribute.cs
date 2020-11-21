using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class EditorWindowTitleAttribute : Attribute
{
    public string icon { get; set; }
    public string title { get; set; }
    public bool useTypeNameAsIconName { get; set; }

    public EditorWindowTitleAttribute();

}

}
