using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing.Procedural
{

public struct TextureStackRequestHandle<T> : IEquatable<Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>>
{
    static public void CompleteRequests(Unity.Collections.NativeSlice<Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> requestHandles, Unity.Collections.NativeSlice<Rendering.VirtualTexturing.Procedural.RequestStatus> status);
    static public void GetRequestParameters(Unity.Collections.NativeSlice<Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> handles, Unity.Collections.NativeSlice<T> requests);

    public void CompleteRequest(Rendering.VirtualTexturing.Procedural.RequestStatus status);
    public bool Equals(object obj);
    public bool Equals(Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T> other);
    public int GetHashCode();
    public T GetRequestParameters();

}

}
