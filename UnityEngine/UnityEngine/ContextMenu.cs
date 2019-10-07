using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ContextMenu : Attribute
{
    public string menuItem;
    public int priority;
    public bool validate;

    public ContextMenu(string itemName);
    public ContextMenu(string itemName, bool isValidateFunction);
    public ContextMenu(string itemName, bool isValidateFunction, int priority);

}

}
