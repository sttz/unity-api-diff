using System;
using System.Collections;
using System.Collections.Generic;
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
    public string[] GetAllIds();
    public int GetAllIds(string[] ids);
    public XR.WSA.WorldAnchor Load(string id, GameObject go);
    public bool Save(string id, XR.WSA.WorldAnchor anchor);

    public delegate void GetAsyncDelegate(XR.WSA.Persistence.WorldAnchorStore store);

}

}
