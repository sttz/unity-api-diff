using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class CullingGroup : IDisposable
{
    static public void EraseSwapBack<T>(int index, T[] myArray, int size);

    public bool enabled { get; set; }
    public StateChanged onStateChanged { get; set; }
    public Camera targetCamera { get; set; }

    public CullingGroup();

    public void Dispose();
    public void EraseSwapBack(int index);
    public int GetDistance(int index);
    public bool IsVisible(int index);
    public int QueryIndices(int distanceIndex, int[] result, int firstIndex);
    public int QueryIndices(bool visible, int[] result, int firstIndex);
    public int QueryIndices(bool visible, int distanceIndex, int[] result, int firstIndex);
    public void SetBoundingDistances(float[] distances);
    public void SetBoundingSphereCount(int count);
    public void SetBoundingSpheres(BoundingSphere[] array);
    public void SetDistanceReferencePoint(Vector3 point);
    public void SetDistanceReferencePoint(Transform transform);

    public delegate void StateChanged(CullingGroupEvent sphere);

}

}
