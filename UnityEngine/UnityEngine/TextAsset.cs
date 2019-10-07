using System;
using UnityEngine;

namespace UnityEngine
{

public class TextAsset : Object
{
    public byte[] bytes { get; }
    public string text { get; }

    public TextAsset();
    public TextAsset(string text);

    public string ToString();

}

}
