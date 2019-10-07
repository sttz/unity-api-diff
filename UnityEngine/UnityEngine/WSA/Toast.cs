using System;
using UnityEngine;

namespace UnityEngine.WSA
{

public sealed class Toast
{
    static public WSA.Toast Create(string xml);
    static public WSA.Toast Create(string image, string text);
    static public string GetTemplate(WSA.ToastTemplate templ);

    public bool activated { get; }
    public string arguments { get; set; }
    public bool dismissed { get; }
    public bool dismissedByUser { get; }

    public void Hide();
    public void Show();

}

}
