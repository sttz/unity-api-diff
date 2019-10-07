using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public static class UnityWebRequestMultimedia
{
    static public Networking.UnityWebRequest GetAudioClip(string uri, AudioType audioType);
    static public Networking.UnityWebRequest GetAudioClip(Uri uri, AudioType audioType);
    static public Networking.UnityWebRequest GetMovieTexture(string uri);
    static public Networking.UnityWebRequest GetMovieTexture(Uri uri);

}

}
