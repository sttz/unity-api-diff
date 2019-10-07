using System;
using UnityEngine;

namespace UnityEngine
{

public class ColorUtility
{
    static public string ToHtmlStringRGB(Color color);
    static public string ToHtmlStringRGBA(Color color);
    static public bool TryParseHtmlString(string htmlString, out Color color);

    public ColorUtility();

}

}
