using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class ScreenCapture
{
    static public void CaptureScreenshot(string filename);
    static public void CaptureScreenshot(string filename, StereoScreenCaptureMode stereoCaptureMode);
    static public void CaptureScreenshot(string filename, int superSize);
    static public Texture2D CaptureScreenshotAsTexture();
    static public Texture2D CaptureScreenshotAsTexture(StereoScreenCaptureMode stereoCaptureMode);
    static public Texture2D CaptureScreenshotAsTexture(int superSize);
    static public void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture);

    public enum StereoScreenCaptureMode
    {
        LeftEye = 1,
        RightEye = 2,
        BothEyes = 3,
    }

}

}
