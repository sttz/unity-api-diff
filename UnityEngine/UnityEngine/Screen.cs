using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Screen
{
    static public bool autorotateToLandscapeLeft { get; set; }
    static public bool autorotateToLandscapeRight { get; set; }
    static public bool autorotateToPortrait { get; set; }
    static public bool autorotateToPortraitUpsideDown { get; set; }
    static public Resolution currentResolution { get; }
    static public float dpi { get; }
    static public bool fullScreen { get; set; }
    static public FullScreenMode fullScreenMode { get; set; }
    static public Resolution[] GetResolution { get; }
    static public int height { get; }
    static public bool lockCursor { get; set; }
    static public ScreenOrientation orientation { get; set; }
    static public Resolution[] resolutions { get; }
    static public Rect safeArea { get; }
    static public bool showCursor { get; set; }
    static public int sleepTimeout { get; set; }
    static public int width { get; }

    static public void SetResolution(int width, int height, bool fullscreen);
    static public void SetResolution(int width, int height, FullScreenMode fullscreenMode);
    static public void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate);
    static public void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate);

    public Screen();

}

}
