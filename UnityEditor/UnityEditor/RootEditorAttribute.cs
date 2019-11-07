using System;
using UnityEngine;

namespace UnityEditor
{

public class RootEditorAttribute : Attribute
{
    public bool supportsAddComponent;

    public RootEditorAttribute(bool supportsAddComponent = false);

    public delegate Type RootEditorHandler(Object[] objects);

}

}
