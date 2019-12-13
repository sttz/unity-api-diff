using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Sharing
{

public class WorldAnchorTransferBatch : IDisposable
{
    static public void ExportAsync(XR.WSA.Sharing.WorldAnchorTransferBatch transferBatch, SerializationDataAvailableDelegate onDataAvailable, SerializationCompleteDelegate onCompleted);
    static public void ImportAsync(byte[] serializedData, DeserializationCompleteDelegate onComplete);
    static public void ImportAsync(byte[] serializedData, int offset, int length, DeserializationCompleteDelegate onComplete);

    public int anchorCount { get; }

    public WorldAnchorTransferBatch();

    public bool AddWorldAnchor(string id, XR.WSA.WorldAnchor anchor);
    public void Dispose();
    public int GetAllIds(string[] ids);
    public string[] GetAllIds();
    public XR.WSA.WorldAnchor LockObject(string id, GameObject go);

    public delegate void SerializationDataAvailableDelegate(byte[] data);

    public delegate void SerializationCompleteDelegate(XR.WSA.Sharing.SerializationCompletionReason completionReason);

    public delegate void DeserializationCompleteDelegate(XR.WSA.Sharing.SerializationCompletionReason completionReason, XR.WSA.Sharing.WorldAnchorTransferBatch deserializedTransferBatch);

}

}