using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Apple
{

public class FrameCapture
{
    static public void BeginCapture();
    static public void BeginCaptureToFile(string path);
    static public void EndCapture();
    static public bool IsDestinationSupported(Apple.FrameCaptureDestination dest);

}

}
