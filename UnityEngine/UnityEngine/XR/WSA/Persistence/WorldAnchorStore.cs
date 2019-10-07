using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Persistence
{

public class WorldAnchorStore : IDisposable
{
    static public void GetAsync(GetAsyncDelegate onCompleted);

    public int anchorCount { get; }

    public void Clear();
    public bool Delete(string id);
    public void Dispose();
    public int GetAllIds(string[] ids);
    public string[] GetAllIds();
    public XR.WSA.WorldAnchor Load(string id, GameObject go);
    public bool Save(string id, XR.WSA.WorldAnchor anchor);

    public delegate void GetAsyncDelegate(XR.WSA.Persistence.WorldAnchorStore store);

}

}
