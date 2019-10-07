using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class UnityWebRequestAsyncOperation : AsyncOperation
{
    public Networking.UnityWebRequest webRequest { get; internal set; }

    public UnityWebRequestAsyncOperation();

}

}
