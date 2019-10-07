using System;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class ADInterstitialAd
{
    static public bool isAvailable { get; }

    static public event InterstitialWasLoadedDelegate onInterstitialWasLoaded;
    static public event InterstitialWasViewedDelegate onInterstitialWasViewed;

    public bool loaded { get; }

    public ADInterstitialAd(bool autoReload);
    public ADInterstitialAd();

    public void ReloadAd();
    public void Show();

    public delegate void InterstitialWasLoadedDelegate();

    public delegate void InterstitialWasViewedDelegate();

}

}
