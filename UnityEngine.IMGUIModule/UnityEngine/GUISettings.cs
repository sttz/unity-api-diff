using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GUISettings
{
    public Color cursorColor { get; set; }
    public float cursorFlashSpeed { get; set; }
    public bool doubleClickSelectsWord { get; set; }
    public Color selectionColor { get; set; }
    public bool tripleClickSelectsLine { get; set; }

    public GUISettings();

}

}
