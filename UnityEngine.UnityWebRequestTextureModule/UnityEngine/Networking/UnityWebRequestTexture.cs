using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public static class UnityWebRequestTexture
{
    static public Networking.UnityWebRequest GetTexture(string uri);
    static public Networking.UnityWebRequest GetTexture(Uri uri);
    static public Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
    static public Networking.UnityWebRequest GetTexture(Uri uri, bool nonReadable);

}

}
