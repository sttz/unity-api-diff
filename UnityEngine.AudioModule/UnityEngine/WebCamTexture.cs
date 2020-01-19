using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class WebCamTexture : Texture
{
    static public WebCamDevice[] devices { get; }

    public Nullable<Vector2> autoFocusPoint { get; set; }
    public string deviceName { get; set; }
    public bool didUpdateThisFrame { get; }
    public bool isDepth { get; }
    public bool isPlaying { get; }
    public float requestedFPS { get; set; }
    public int requestedHeight { get; set; }
    public int requestedWidth { get; set; }
    public int videoRotationAngle { get; }
    public bool videoVerticallyMirrored { get; }

    public WebCamTexture();
    public WebCamTexture(string deviceName);
    public WebCamTexture(int requestedWidth, int requestedHeight);
    public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight);
    public WebCamTexture(int requestedWidth, int requestedHeight, int requestedFPS);
    public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight, int requestedFPS);

    public Color GetPixel(int x, int y);
    public Color[] GetPixels();
    public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
    public Color32[] GetPixels32();
    public Color32[] GetPixels32(Color32[] colors);
    public void Pause();
    public void Play();
    public void Stop();

}

}
