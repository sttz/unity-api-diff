using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SerializedProperty : IDisposable
{
    static public bool DataEquals(UnityEditor.SerializedProperty x, UnityEditor.SerializedProperty y);
    static public bool EqualContents(UnityEditor.SerializedProperty x, UnityEditor.SerializedProperty y);

    public AnimationCurve animationCurveValue { get; set; }
    public string arrayElementType { get; }
    public int arraySize { get; set; }
    public bool boolValue { get; set; }
    public BoundsInt boundsIntValue { get; set; }
    public Bounds boundsValue { get; set; }
    public Color colorValue { get; set; }
    public int depth { get; }
    public string displayName { get; }
    public double doubleValue { get; set; }
    public bool editable { get; }
    public string[] enumDisplayNames { get; }
    public string[] enumNames { get; }
    public int enumValueIndex { get; set; }
    public Object exposedReferenceValue { get; set; }
    public int fixedBufferSize { get; }
    public float floatValue { get; set; }
    public bool hasChildren { get; }
    public Hash128 hash128Value { get; set; }
    public bool hasMultipleDifferentValues { get; }
    public bool hasVisibleChildren { get; }
    public int intValue { get; set; }
    public bool isAnimated { get; }
    public bool isArray { get; }
    public bool isDefaultOverride { get; }
    public bool isExpanded { get; set; }
    public bool isFixedBuffer { get; }
    public bool isInstantiatedPrefab { get; }
    public long longValue { get; set; }
    public string managedReferenceFieldTypename { get; }
    public string managedReferenceFullTypename { get; }
    public object managedReferenceValue { set; }
    public string name { get; }
    public int objectReferenceInstanceIDValue { get; set; }
    public Object objectReferenceValue { get; set; }
    public bool prefabOverride { get; set; }
    public string propertyPath { get; }
    public UnityEditor.SerializedPropertyType propertyType { get; }
    public Quaternion quaternionValue { get; set; }
    public RectInt rectIntValue { get; set; }
    public Rect rectValue { get; set; }
    public UnityEditor.SerializedObject serializedObject { get; }
    public string stringValue { get; set; }
    public string tooltip { get; }
    public string type { get; }
    public Vector2Int vector2IntValue { get; set; }
    public Vector2 vector2Value { get; set; }
    public Vector3Int vector3IntValue { get; set; }
    public Vector3 vector3Value { get; set; }
    public Vector4 vector4Value { get; set; }

    public void ClearArray();
    public UnityEditor.SerializedProperty Copy();
    public int CountInProperty();
    public int CountRemaining();
    public void DeleteArrayElementAtIndex(int index);
    public bool DeleteCommand();
    public void Dispose();
    public bool DuplicateCommand();
    public UnityEditor.SerializedProperty FindPropertyRelative(string relativePropertyPath);
    public UnityEditor.SerializedProperty GetArrayElementAtIndex(int index);
    public UnityEditor.SerializedProperty GetEndProperty();
    public UnityEditor.SerializedProperty GetEndProperty(bool includeInvisible);
    public IEnumerator GetEnumerator();
    public UnityEditor.SerializedProperty GetFixedBufferElementAtIndex(int index);
    public void InsertArrayElementAtIndex(int index);
    public bool MoveArrayElement(int srcIndex, int dstIndex);
    public bool Next(bool enterChildren);
    public bool NextVisible(bool enterChildren);
    public void Reset();

}

}
