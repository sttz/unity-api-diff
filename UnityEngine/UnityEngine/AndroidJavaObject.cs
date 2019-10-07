using System;
using UnityEngine;

namespace UnityEngine
{

public class AndroidJavaObject : IDisposable
{
    public AndroidJavaObject(string className, string[] args);
    public AndroidJavaObject(string className, AndroidJavaObject[] args);
    public AndroidJavaObject(string className, AndroidJavaClass[] args);
    public AndroidJavaObject(string className, AndroidJavaProxy[] args);
    public AndroidJavaObject(string className, AndroidJavaRunnable[] args);
    public AndroidJavaObject(string className, object[] args);

    protected void _Call(string methodName, object[] args);
    protected ReturnType _Call(string methodName, object[] args);
    protected void _CallStatic(string methodName, object[] args);
    protected ReturnType _CallStatic(string methodName, object[] args);
    protected FieldType _Get(string fieldName);
    protected IntPtr _GetRawClass();
    protected IntPtr _GetRawObject();
    protected FieldType _GetStatic(string fieldName);
    protected void _Set(string fieldName, FieldType val);
    protected void _SetStatic(string fieldName, FieldType val);
    public void Call(string methodName, T[] args);
    public void Call(string methodName, object[] args);
    public ReturnType Call(string methodName, T[] args);
    public ReturnType Call(string methodName, object[] args);
    public void CallStatic(string methodName, T[] args);
    public void CallStatic(string methodName, object[] args);
    public ReturnType CallStatic(string methodName, T[] args);
    public ReturnType CallStatic(string methodName, object[] args);
    protected void DebugPrint(string msg);
    protected void DebugPrint(string call, string methodName, string signature, object[] args);
    public void Dispose();
    protected void Dispose(bool disposing);
    public FieldType Get(string fieldName);
    public IntPtr GetRawClass();
    public IntPtr GetRawObject();
    public FieldType GetStatic(string fieldName);
    public void Set(string fieldName, FieldType val);
    public void SetStatic(string fieldName, FieldType val);

}

}
