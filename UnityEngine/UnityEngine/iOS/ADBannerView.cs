using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class ADBannerView
{
    static public event BannerFailedToLoadDelegate onBannerFailedToLoad;
    static public event BannerWasClickedDelegate onBannerWasClicked;
    static public event BannerWasLoadedDelegate onBannerWasLoaded;

    static public bool IsAvailable(Type type);

    public Layout layout { get; set; }
    public bool loaded { get; }
    public Vector2 position { get; set; }
    public Vector2 size { get; }
    public bool visible { get; set; }

    public ADBannerView(Type type, Layout layout);

    public delegate void BannerFailedToLoadDelegate();

    public delegate void BannerWasClickedDelegate();

    public delegate void BannerWasLoadedDelegate();

    public enum Layout
    {
        Manual = -1,
        Top = 0,
        TopLeft = 0,
        Bottom = 1,
        BottomLeft = 1,
        CenterLeft = 2,
        TopRight = 4,
        BottomRight = 5,
        CenterRight = 6,
        TopCenter = 8,
        BottomCenter = 9,
        Center = 10,
    }

    public enum Type
    {
        Banner = 0,
        MediumRect = 1,
    }

}

}
