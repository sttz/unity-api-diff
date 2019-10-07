using System;
using UnityEngine;

namespace UnityEngine
{

public class TouchScreenKeyboard
{
    static public Rect area { get; }
    static public bool hideInput { get; set; }
    static public bool isInPlaceEditingAllowed { get; }
    static public bool isSupported { get; }
    static public bool visible { get; }

    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder);
    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert);
    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline);
    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection);
    static public TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType);
    static public TouchScreenKeyboard Open(string text);

    public bool active { get; set; }
    public bool canGetSelection { get; }
    public bool canSetSelection { get; }
    public int characterLimit { get; set; }
    public bool done { get; }
    public RangeInt selection { get; set; }
    public Status status { get; }
    public int targetDisplay { get; set; }
    public string text { get; set; }
    public TouchScreenKeyboardType type { get; }
    public bool wasCanceled { get; }

    public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);

    public enum Status
    {
        Visible = 0,
        Done = 1,
        Canceled = 2,
        LostFocus = 3,
    }

}

}
