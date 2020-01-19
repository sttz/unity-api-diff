using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ADInterstitialAd
{
    static public bool isAvailable { get; }

    static public event InterstitialWasLoadedDelegate onInterstitialWasLoaded;

    public bool loaded { get; }

    public ADInterstitialAd();
    public ADInterstitialAd(bool autoReload);

    public void ReloadAd();
    public void Show();

    public delegate void InterstitialWasLoadedDelegate();

}

}
