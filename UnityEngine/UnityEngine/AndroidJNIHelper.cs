using System;
using UnityEngine;

namespace UnityEngine
{

public static class AndroidJNIHelper
{
    static public bool debug { get; set; }

    static public ArrayType ConvertFromJNIArray(IntPtr array);
    static public IntPtr ConvertToJNIArray(Array array);
    static public IntPtr CreateJavaProxy(AndroidJavaProxy proxy);
    static public IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable);
    static public jvalue[] CreateJNIArgArray(object[] args);
    static public void DeleteJNIArgArray(object[] args, jvalue[] jniArgs);
    static public IntPtr GetConstructorID(IntPtr javaClass);
    static public IntPtr GetConstructorID(IntPtr javaClass, string signature);
    static public IntPtr GetConstructorID(IntPtr jclass, object[] args);
    static public IntPtr GetFieldID(IntPtr javaClass, string fieldName);
    static public IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature);
    static public IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic);
    static public IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic);
    static public IntPtr GetMethodID(IntPtr javaClass, string methodName);
    static public IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature);
    static public IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic);
    static public IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic);
    static public IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic);
    static public string GetSignature(object obj);
    static public string GetSignature(object[] args);
    static public string GetSignature(object[] args);

}

}
