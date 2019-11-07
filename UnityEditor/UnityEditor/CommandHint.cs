using System;
using UnityEngine;

namespace UnityEditor
{

public enum CommandHint : long
{
    Undefined = -1,
    None = 0,
    Event = 1,
    Menu = 2,
    Shortcut = 4,
    Shelf = 8,
    UI = 1048576,
    OnGUI = 3145728,
    UIElements = 5242880,
    Validate = 1073741824,
    UserDefined = -2147483648,
    Any = -1,
}

}
