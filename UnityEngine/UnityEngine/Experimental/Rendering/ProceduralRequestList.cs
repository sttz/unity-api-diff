using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class ProceduralRequestList : IDisposable
{
    public Experimental.Rendering.ProceduralTextureStackRequest this[int index] { get; }
    public int Length { get; private set; }

    public void Dispose();
    public void MarkAsFinished(int count = -1);

}

}
