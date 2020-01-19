using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUIContent
{
    static public GUIContent none;

    public Texture image { get; set; }
    public string text { get; set; }
    public string tooltip { get; set; }

    public GUIContent();
    public GUIContent(Texture image);
    public GUIContent(GUIContent src);
    public GUIContent(string text);
    public GUIContent(Texture image, string tooltip);
    public GUIContent(string text, Texture image);
    public GUIContent(string text, string tooltip);
    public GUIContent(string text, Texture image, string tooltip);

}

}
