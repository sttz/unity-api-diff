using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GUIStyleState
{
    public Texture2D background { get; set; }
    public Texture2D[] scaledBackgrounds { get; set; }
    public Color textColor { get; set; }

    public GUIStyleState();

}

}