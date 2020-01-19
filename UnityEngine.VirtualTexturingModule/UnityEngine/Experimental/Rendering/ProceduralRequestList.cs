using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class ProceduralRequestList : IDisposable
{
    public Experimental.Rendering.ProceduralTextureStackRequest this[int index] { get; }
    public int Length { get; private set; }

    public void Apply();
    public void Dispose();
    public void MarkAllRequestsFinished();
    public void UpdateRequestStatus(Experimental.Rendering.ProceduralTextureStackRequest request, RequestStatus status);

    public enum RequestStatus
    {
        Dropped = 0,
        Complete = 1,
    }

}

}
