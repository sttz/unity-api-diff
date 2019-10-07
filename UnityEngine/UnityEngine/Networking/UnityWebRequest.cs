using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class UnityWebRequest : IDisposable
{
    static public string kHttpVerbCREATE = "CREATE";
    static public string kHttpVerbDELETE = "DELETE";
    static public string kHttpVerbGET = "GET";
    static public string kHttpVerbHEAD = "HEAD";
    static public string kHttpVerbPOST = "POST";
    static public string kHttpVerbPUT = "PUT";

    static public void ClearCookieCache();
    static public void ClearCookieCache(Uri uri);
    static public Networking.UnityWebRequest Delete(string uri);
    static public Networking.UnityWebRequest Delete(Uri uri);
    static public string EscapeURL(string s);
    static public string EscapeURL(string s, System.Text.Encoding e);
    static public byte[] GenerateBoundary();
    static public Networking.UnityWebRequest Get(string uri);
    static public Networking.UnityWebRequest Get(Uri uri);
    static public Networking.UnityWebRequest GetAssetBundle(string uri);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, uint version, uint crc);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc);
    static public Networking.UnityWebRequest GetAudioClip(string uri, AudioType audioType);
    static public Networking.UnityWebRequest GetTexture(string uri);
    static public Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
    static public Networking.UnityWebRequest Head(string uri);
    static public Networking.UnityWebRequest Head(Uri uri);
    static public Networking.UnityWebRequest Post(string uri, string postData);
    static public Networking.UnityWebRequest Post(Uri uri, string postData);
    static public Networking.UnityWebRequest Post(string uri, WWWForm formData);
    static public Networking.UnityWebRequest Post(Uri uri, WWWForm formData);
    static public Networking.UnityWebRequest Post(string uri, System.Collections.Generic.List<Networking.IMultipartFormSection> multipartFormSections);
    static public Networking.UnityWebRequest Post(Uri uri, System.Collections.Generic.List<Networking.IMultipartFormSection> multipartFormSections);
    static public Networking.UnityWebRequest Post(string uri, System.Collections.Generic.List<Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
    static public Networking.UnityWebRequest Post(Uri uri, System.Collections.Generic.List<Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
    static public Networking.UnityWebRequest Post(string uri, System.Collections.Generic.Dictionary<string, string> formFields);
    static public Networking.UnityWebRequest Post(Uri uri, System.Collections.Generic.Dictionary<string, string> formFields);
    static public Networking.UnityWebRequest Put(string uri, byte[] bodyData);
    static public Networking.UnityWebRequest Put(Uri uri, byte[] bodyData);
    static public Networking.UnityWebRequest Put(string uri, string bodyData);
    static public Networking.UnityWebRequest Put(Uri uri, string bodyData);
    static public byte[] SerializeFormSections(System.Collections.Generic.List<Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
    static public byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<string, string> formFields);
    static public string UnEscapeURL(string s);
    static public string UnEscapeURL(string s, System.Text.Encoding e);

    public Networking.CertificateHandler certificateHandler { get; set; }
    public bool chunkedTransfer { get; set; }
    public bool disposeCertificateHandlerOnDispose { get; set; }
    public bool disposeDownloadHandlerOnDispose { get; set; }
    public bool disposeUploadHandlerOnDispose { get; set; }
    public ulong downloadedBytes { get; }
    public Networking.DownloadHandler downloadHandler { get; set; }
    public float downloadProgress { get; }
    public string error { get; }
    public bool isDone { get; }
    public bool isError { get; }
    public bool isHttpError { get; }
    public bool isModifiable { get; }
    public bool isNetworkError { get; }
    public string method { get; set; }
    public int redirectLimit { get; set; }
    public long responseCode { get; }
    public int timeout { get; set; }
    public ulong uploadedBytes { get; }
    public Networking.UploadHandler uploadHandler { get; set; }
    public float uploadProgress { get; }
    public Uri uri { get; set; }
    public string url { get; set; }
    public bool useHttpContinue { get; set; }

    public UnityWebRequest();
    public UnityWebRequest(string url);
    public UnityWebRequest(Uri uri);
    public UnityWebRequest(string url, string method);
    public UnityWebRequest(Uri uri, string method);
    public UnityWebRequest(string url, string method, Networking.DownloadHandler downloadHandler, Networking.UploadHandler uploadHandler);
    public UnityWebRequest(Uri uri, string method, Networking.DownloadHandler downloadHandler, Networking.UploadHandler uploadHandler);

    public void Abort();
    public void Dispose();
    public string GetRequestHeader(string name);
    public string GetResponseHeader(string name);
    public System.Collections.Generic.Dictionary<string, string> GetResponseHeaders();
    public AsyncOperation Send();
    public Networking.UnityWebRequestAsyncOperation SendWebRequest();
    public void SetRequestHeader(string name, string value);

}

}
