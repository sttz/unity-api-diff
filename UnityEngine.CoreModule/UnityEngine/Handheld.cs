using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Handheld
{
    static public bool use32BitDisplayBuffer { get; set; }

    static public void ClearShaderCache();
    static public int GetActivityIndicatorStyle();
    static public bool PlayFullScreenMovie(string path);
    static public bool PlayFullScreenMovie(string path, Color bgColor);
    static public bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode);
    static public bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode);
    static public void SetActivityIndicatorStyle(AndroidActivityIndicatorStyle style);
    static public void SetActivityIndicatorStyle(iOS.ActivityIndicatorStyle style);
    static public void StartActivityIndicator();
    static public void StopActivityIndicator();
    static public void Vibrate();

    public Handheld();

}

}
