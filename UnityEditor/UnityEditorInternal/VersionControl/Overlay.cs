using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{

public class Overlay
{
    static public void DrawOverlay(UnityEditor.VersionControl.Asset asset, Rect itemRect);
    static public void DrawOverlay(UnityEditor.VersionControl.Asset asset, UnityEditor.VersionControl.Asset metaAsset, Rect itemRect);
    static public Rect GetOverlayRect(Rect itemRect);

    public Overlay();

}

}
