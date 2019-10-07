using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ADInterstitialAd
{
    static public bool isAvailable { get; }

    static public event InterstitialWasLoadedDelegate onInterstitialWasLoaded;

    public bool loaded { get; }

    public ADInterstitialAd(bool autoReload);
    public ADInterstitialAd();

    public void ReloadAd();
    public void Show();

    public delegate void InterstitialWasLoadedDelegate();

}

}
