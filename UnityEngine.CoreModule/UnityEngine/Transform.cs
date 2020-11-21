using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Transform : Component, IEnumerable
{
    public int childCount { get; }
    public Vector3 eulerAngles { get; set; }
    public Vector3 forward { get; set; }
    public bool hasChanged { get; set; }
    public int hierarchyCapacity { get; set; }
    public int hierarchyCount { get; }
    public Vector3 localEulerAngles { get; set; }
    public Vector3 localPosition { get; set; }
    public Quaternion localRotation { get; set; }
    public Vector3 localScale { get; set; }
    public Matrix4x4 localToWorldMatrix { get; }
    public Vector3 lossyScale { get; }
    public Transform parent { get; set; }
    public Vector3 position { get; set; }
    public Vector3 right { get; set; }
    public Transform root { get; }
    public Quaternion rotation { get; set; }
    public Vector3 up { get; set; }
    public Matrix4x4 worldToLocalMatrix { get; }

    protected Transform();

    public void DetachChildren();
    public Transform Find(string n);
    public Transform FindChild(string n);
    public Transform GetChild(int index);
    public int GetChildCount();
    public IEnumerator GetEnumerator();
    public int GetSiblingIndex();
    public Vector3 InverseTransformDirection(Vector3 direction);
    public Vector3 InverseTransformDirection(float x, float y, float z);
    public Vector3 InverseTransformPoint(Vector3 position);
    public Vector3 InverseTransformPoint(float x, float y, float z);
    public Vector3 InverseTransformVector(Vector3 vector);
    public Vector3 InverseTransformVector(float x, float y, float z);
    public bool IsChildOf(Transform parent);
    public void LookAt(Transform target);
    public void LookAt(Vector3 worldPosition);
    public void LookAt(Transform target, Vector3 worldUp);
    public void LookAt(Vector3 worldPosition, Vector3 worldUp);
    public void Rotate(Vector3 eulers);
    public void Rotate(Vector3 axis, float angle);
    public void Rotate(Vector3 eulers, Space relativeTo);
    public void Rotate(Vector3 axis, float angle, Space relativeTo);
    public void Rotate(float xAngle, float yAngle, float zAngle);
    public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo);
    public void RotateAround(Vector3 axis, float angle);
    public void RotateAround(Vector3 point, Vector3 axis, float angle);
    public void RotateAroundLocal(Vector3 axis, float angle);
    public void SetAsFirstSibling();
    public void SetAsLastSibling();
    public void SetParent(Transform p);
    public void SetParent(Transform parent, bool worldPositionStays);
    public void SetPositionAndRotation(Vector3 position, Quaternion rotation);
    public void SetSiblingIndex(int index);
    public Vector3 TransformDirection(Vector3 direction);
    public Vector3 TransformDirection(float x, float y, float z);
    public Vector3 TransformPoint(Vector3 position);
    public Vector3 TransformPoint(float x, float y, float z);
    public Vector3 TransformVector(Vector3 vector);
    public Vector3 TransformVector(float x, float y, float z);
    public void Translate(Vector3 translation);
    public void Translate(Vector3 translation, Space relativeTo);
    public void Translate(Vector3 translation, Transform relativeTo);
    public void Translate(float x, float y, float z);
    public void Translate(float x, float y, float z, Space relativeTo);
    public void Translate(float x, float y, float z, Transform relativeTo);

}

}
