using System;
using UnityEngine;

namespace UnityEngine
{

public class Display
{
    static public Display[] displays;

    static public Display main { get; }

    static public event DisplaysUpdatedDelegate onDisplaysUpdated;

    static public bool MultiDisplayLicense();
    static public Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates);

    public bool active { get; }
    public RenderBuffer colorBuffer { get; }
    public RenderBuffer depthBuffer { get; }
    public int renderingHeight { get; }
    public int renderingWidth { get; }
    public int systemHeight { get; }
    public int systemWidth { get; }

    public void Activate();
    public void Activate(int width, int height, int refreshRate);
    public void SetParams(int width, int height, int x, int y);
    public void SetRenderingResolution(int w, int h);

    public delegate void DisplaysUpdatedDelegate();

}

}
