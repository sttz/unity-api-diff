using System;
using UnityEngine;

namespace UnityEngine
{

public class ContextMenuItemAttribute : PropertyAttribute
{
    public string function;
    public string name;

    public ContextMenuItemAttribute(string name, string function);

}

}
