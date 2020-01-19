using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class ADInterstitialAd
{
    static public bool isAvailable { get; }

    static public event InterstitialWasLoadedDelegate onInterstitialWasLoaded;
    static public event InterstitialWasViewedDelegate onInterstitialWasViewed;

    public bool loaded { get; }

    public ADInterstitialAd();
    public ADInterstitialAd(bool autoReload);

    public void ReloadAd();
    public void Show();

    public delegate void InterstitialWasLoadedDelegate();

    public delegate void InterstitialWasViewedDelegate();

}

}
