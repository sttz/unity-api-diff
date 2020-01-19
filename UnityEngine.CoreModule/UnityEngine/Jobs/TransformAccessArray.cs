using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Jobs
{

public struct TransformAccessArray : IDisposable
{
    static public void Allocate(int capacity, int desiredJobCount, out Jobs.TransformAccessArray array);

    public int capacity { get; set; }
    public bool isCreated { get; }
    public Transform this[int index] { get; set; }
    public int length { get; }

    public TransformAccessArray(int capacity, int desiredJobCount = -1);
    public TransformAccessArray(Transform[] transforms, int desiredJobCount = -1);

    public void Add(Transform transform);
    public void Dispose();
    public void RemoveAtSwapBack(int index);
    public void SetTransforms(Transform[] transforms);

}

}
