using System;
using UnityEngine;

namespace UnityEngine
{

public class AndroidInput
{
    static public bool secondaryTouchEnabled { get; }
    static public int secondaryTouchHeight { get; }
    static public int secondaryTouchWidth { get; }
    static public int touchCountSecondary { get; }

    static public Touch GetSecondaryTouch(int index);

}

}
