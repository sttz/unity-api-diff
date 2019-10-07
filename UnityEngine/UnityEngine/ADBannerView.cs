using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ADBannerView
{
    static public event BannerWasClickedDelegate onBannerWasClicked;
    static public event BannerWasLoadedDelegate onBannerWasLoaded;

    static public bool IsAvailable(Type type);

    public Layout layout { get; set; }
    public bool loaded { get; }
    public Vector2 position { get; set; }
    public Vector2 size { get; }
    public bool visible { get; set; }

    public ADBannerView(Type type, Layout layout);

    public enum Layout
    {
        Top = 0,
        Bottom = 1,
        TopLeft = 0,
        TopRight = 4,
        TopCenter = 8,
        BottomLeft = 1,
        BottomRight = 5,
        BottomCenter = 9,
        CenterLeft = 2,
        CenterRight = 6,
        Center = 10,
        Manual = -1,
    }

    public enum Type
    {
        Banner = 0,
        MediumRect = 1,
    }

    public delegate void BannerWasClickedDelegate();

    public delegate void BannerWasLoadedDelegate();

}

}
