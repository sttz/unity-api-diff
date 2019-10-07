using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerAudioClip : Networking.DownloadHandler
{
    static public AudioClip GetContent(Networking.UnityWebRequest www);

    public AudioClip audioClip { get; }
    public bool compressed { get; set; }
    public bool streamAudio { get; set; }

    public DownloadHandlerAudioClip(string url, AudioType audioType);
    public DownloadHandlerAudioClip(Uri uri, AudioType audioType);

    protected byte[] GetData();
    protected string GetText();

}

}
