using System;
using UnityEngine;

namespace UnityEngine.WSA
{

public struct SecondaryTileData
{
    public string arguments;
    public bool backgroundColorSet;
    public string displayName;
    public WSA.TileForegroundText foregroundText;
    public string lockScreenBadgeLogo;
    public bool lockScreenDisplayBadgeAndTileText;
    public string phoneticName;
    public bool roamingEnabled;
    public bool showNameOnSquare150x150Logo;
    public bool showNameOnSquare310x310Logo;
    public bool showNameOnWide310x150Logo;
    public string square150x150Logo;
    public string square30x30Logo;
    public string square310x310Logo;
    public string square70x70Logo;
    public string tileId;
    public string wide310x150Logo;

    public Color32 backgroundColor { get; set; }

    public SecondaryTileData(string id, string displayName);

}

}
