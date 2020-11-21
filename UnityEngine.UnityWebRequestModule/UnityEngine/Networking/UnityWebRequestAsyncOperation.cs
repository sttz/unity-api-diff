using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public class UnityWebRequestAsyncOperation : AsyncOperation
{
    public Networking.UnityWebRequest webRequest { get; internal set; }

    public UnityWebRequestAsyncOperation();

}

}
