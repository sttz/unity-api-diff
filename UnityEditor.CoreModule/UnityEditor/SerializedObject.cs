using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SerializedObject : IDisposable
{
    public Object context { get; }
    public bool forceChildVisibility { get; set; }
    public bool hasModifiedProperties { get; }
    public bool isEditingMultipleObjects { get; }
    public int maxArraySizeForMultiEditing { get; set; }
    public Object targetObject { get; }
    public Object[] targetObjects { get; }

    public SerializedObject(Object obj);
    public SerializedObject(Object[] objs);
    public SerializedObject(Object obj, Object context);
    public SerializedObject(Object[] objs, Object context);

    public bool ApplyModifiedProperties();
    public bool ApplyModifiedPropertiesWithoutUndo();
    public void CopyFromSerializedProperty(UnityEditor.SerializedProperty prop);
    public bool CopyFromSerializedPropertyIfDifferent(UnityEditor.SerializedProperty prop);
    public void Dispose();
    public UnityEditor.SerializedProperty FindProperty(string propertyPath);
    public UnityEditor.SerializedProperty GetIterator();
    public void SetIsDifferentCacheDirty();
    public void Update();
    public void UpdateIfDirtyOrScript();
    public bool UpdateIfRequiredOrScript();

}

}
