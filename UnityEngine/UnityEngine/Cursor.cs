using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Cursor
{
    static public CursorLockMode lockState { get; set; }
    static public bool visible { get; set; }

    static public void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode);

    public Cursor();

}

}
