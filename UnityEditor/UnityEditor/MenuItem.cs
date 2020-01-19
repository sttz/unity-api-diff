using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class MenuItem : Attribute
{
    public string menuItem;
    public int priority;
    public bool validate;

    public MenuItem(string itemName);
    public MenuItem(string itemName, bool isValidateFunction);
    public MenuItem(string itemName, bool isValidateFunction, int priority);

}

}
