using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VFX
{

public class VisualEffectAsset : VFX.VisualEffectObject
{
    static public int PlayEventID;
    static public string PlayEventName = "OnPlay";
    static public int StopEventID;
    static public string StopEventName = "OnStop";

    public VisualEffectAsset();

    public void GetEvents(List<string> names);
    public void GetExposedProperties(List<VFX.VFXExposedProperty> exposedProperties);
    public Rendering.TextureDimension GetTextureDimension(string name);
    public Rendering.TextureDimension GetTextureDimension(int nameID);

}

}
