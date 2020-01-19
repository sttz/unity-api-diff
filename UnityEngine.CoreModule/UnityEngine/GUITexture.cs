using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUITexture : GUIElement
{
    public RectOffset border { get; set; }
    public Color color { get; set; }
    public Rect pixelInset { get; set; }
    public Texture texture { get; set; }

    public GUITexture();

}

}
