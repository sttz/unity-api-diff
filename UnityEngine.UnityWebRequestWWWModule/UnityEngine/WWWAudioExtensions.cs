using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class WWWAudioExtensions
{
    static public AudioClip GetAudioClip(WWW www);
    static public AudioClip GetAudioClip(WWW www, bool threeD);
    static public AudioClip GetAudioClip(WWW www, bool threeD, bool stream);
    static public AudioClip GetAudioClip(WWW www, bool threeD, bool stream, AudioType audioType);
    static public AudioClip GetAudioClipCompressed(WWW www);
    static public AudioClip GetAudioClipCompressed(WWW www, bool threeD);
    static public AudioClip GetAudioClipCompressed(WWW www, bool threeD, AudioType audioType);
    static public MovieTexture GetMovieTexture(WWW www);

}

}
