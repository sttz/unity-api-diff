using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class ContentZoomer : UIElements.Manipulator
{
    static public float DefaultMaxScale;
    static public float DefaultMinScale;
    static public float DefaultReferenceScale;
    static public float DefaultScaleStep;

    public bool keepPixelCacheOnZoom { get; set; }
    public float maxScale { get; set; }
    public float minScale { get; set; }
    public float referenceScale { get; set; }
    public float scaleStep { get; set; }

    public ContentZoomer();

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
