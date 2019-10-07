using System;
using UnityEngine;

namespace UnityEngine
{

public class iPhoneKeyboard
{
    static public Rect area { get; }
    static public bool hideInput { get; set; }
    static public bool visible { get; }

    public bool active { get; set; }
    public bool done { get; }
    public string text { get; set; }

    public iPhoneKeyboard();

}

}
