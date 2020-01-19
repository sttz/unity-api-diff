using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class AndroidJavaProxy
{
    public AndroidJavaClass javaInterface;

    public AndroidJavaProxy(string javaInterface);
    public AndroidJavaProxy(AndroidJavaClass javaInterface);

    public bool equals(AndroidJavaObject obj);
    public int hashCode();
    public AndroidJavaObject Invoke(string methodName, object[] args);
    public AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs);
    public string toString();

}

}
