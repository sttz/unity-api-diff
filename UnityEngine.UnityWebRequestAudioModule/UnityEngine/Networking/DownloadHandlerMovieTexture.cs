using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerMovieTexture : Networking.DownloadHandler
{
    static public MovieTexture GetContent(Networking.UnityWebRequest uwr);

    public MovieTexture movieTexture { get; }

    public DownloadHandlerMovieTexture();

    protected byte[] GetData();
    protected string GetText();

}

}
