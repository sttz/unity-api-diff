using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class iPhoneUtils
{
    static public bool isApplicationGenuine { get; }
    static public bool isApplicationGenuineAvailable { get; }

    static public void PlayMovie(string path, Color bgColor);
    static public void PlayMovie(string path, Color bgColor, iPhoneMovieControlMode controlMode);
    static public void PlayMovie(string path, Color bgColor, iPhoneMovieControlMode controlMode, iPhoneMovieScalingMode scalingMode);
    static public void PlayMovieURL(string url, Color bgColor);
    static public void PlayMovieURL(string url, Color bgColor, iPhoneMovieControlMode controlMode);
    static public void PlayMovieURL(string url, Color bgColor, iPhoneMovieControlMode controlMode, iPhoneMovieScalingMode scalingMode);
    static public void Vibrate();

    public iPhoneUtils();

}

}
