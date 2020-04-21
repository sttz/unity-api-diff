using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class WWW : CustomYieldInstruction, IDisposable
{
    static public string EscapeURL(string s);
    static public string EscapeURL(string s, System.Text.Encoding e);
    static public WWW LoadFromCacheOrDownload(string url, Hash128 hash);
    static public WWW LoadFromCacheOrDownload(string url, int version);
    static public WWW LoadFromCacheOrDownload(string url, CachedAssetBundle cachedBundle, uint crc = 0);
    static public WWW LoadFromCacheOrDownload(string url, Hash128 hash, uint crc);
    static public WWW LoadFromCacheOrDownload(string url, int version, uint crc);
    static public string UnEscapeURL(string s);
    static public string UnEscapeURL(string s, System.Text.Encoding e);

    public AssetBundle assetBundle { get; }
    public Object audioClip { get; }
    public byte[] bytes { get; }
    public int bytesDownloaded { get; }
    public string data { get; }
    public string error { get; }
    public bool isDone { get; }
    public bool keepWaiting { get; }
    public Object movie { get; }
    public Object oggVorbis { get; }
    public float progress { get; }
    public Dictionary<string, string> responseHeaders { get; }
    public int size { get; }
    public string text { get; }
    public Texture2D texture { get; }
    public Texture2D textureNonReadable { get; }
    public ThreadPriority threadPriority { get; set; }
    public float uploadProgress { get; }
    public string url { get; }

    public WWW(string url);
    public WWW(string url, WWWForm form);
    public WWW(string url, byte[] postData);
    public WWW(string url, byte[] postData, Dictionary<string, string> headers);
    public WWW(string url, byte[] postData, Hashtable headers);

    public void Dispose();
    public AudioClip GetAudioClip();
    public AudioClip GetAudioClip(bool threeD);
    public AudioClip GetAudioClip(bool threeD, bool stream);
    public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType);
    public AudioClip GetAudioClipCompressed();
    public AudioClip GetAudioClipCompressed(bool threeD);
    public AudioClip GetAudioClipCompressed(bool threeD, AudioType audioType);
    public MovieTexture GetMovieTexture();
    public void LoadImageIntoTexture(Texture2D texture);

}

}
