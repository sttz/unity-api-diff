using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class AndroidJavaObject : IDisposable
{
    static protected AndroidJavaClass JavaLangClass { get; }

    static protected AndroidJavaObject FindClass(string name);

    public AndroidJavaObject(string className, object[] args);

    protected void _Call(string methodName, object[] args);
    protected ReturnType _Call<ReturnType>(string methodName, object[] args);
    protected void _CallStatic(string methodName, object[] args);
    protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
    protected void _Dispose();
    protected FieldType _Get<FieldType>(string fieldName);
    protected IntPtr _GetRawClass();
    protected IntPtr _GetRawObject();
    protected FieldType _GetStatic<FieldType>(string fieldName);
    protected void _Set<FieldType>(string fieldName, FieldType val);
    protected void _SetStatic<FieldType>(string fieldName, FieldType val);
    public void Call(string methodName, object[] args);
    public ReturnType Call<ReturnType>(string methodName, object[] args);
    public void CallStatic(string methodName, object[] args);
    public ReturnType CallStatic<ReturnType>(string methodName, object[] args);
    protected void DebugPrint(string msg);
    protected void DebugPrint(string call, string methodName, string signature, object[] args);
    public void Dispose();
    protected void Dispose(bool disposing);
    public FieldType Get<FieldType>(string fieldName);
    public IntPtr GetRawClass();
    public IntPtr GetRawObject();
    public FieldType GetStatic<FieldType>(string fieldName);
    public void Set<FieldType>(string fieldName, FieldType val);
    public void SetStatic<FieldType>(string fieldName, FieldType val);

}

}
