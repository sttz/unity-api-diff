using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Debug
{
    static public bool developerConsoleVisible { get; set; }
    static public bool isDebugBuild { get; }
    static public ILogger logger { get; }
    static public ILogger unityLogger { get; }

    static public void Assert(bool condition);
    static public void Assert(bool condition, Object context);
    static public void Assert(bool condition, object message);
    static public void Assert(bool condition, string message);
    static public void Assert(bool condition, string format, object[] args);
    static public void Assert(bool condition, object message, Object context);
    static public void Assert(bool condition, string message, Object context);
    static public void AssertFormat(bool condition, string format, object[] args);
    static public void AssertFormat(bool condition, Object context, string format, object[] args);
    static public void Break();
    static public void ClearDeveloperConsole();
    static public void DebugBreak();
    static public void DrawLine(Vector3 start, Vector3 end);
    static public void DrawLine(Vector3 start, Vector3 end, Color color);
    static public void DrawLine(Vector3 start, Vector3 end, Color color, float duration);
    static public void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest);
    static public void DrawRay(Vector3 start, Vector3 dir);
    static public void DrawRay(Vector3 start, Vector3 dir, Color color);
    static public void DrawRay(Vector3 start, Vector3 dir, Color color, float duration);
    static public void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest);
    static public void Log(object message);
    static public void Log(object message, Object context);
    static public void LogAssertion(object message);
    static public void LogAssertion(object message, Object context);
    static public void LogAssertionFormat(string format, object[] args);
    static public void LogAssertionFormat(Object context, string format, object[] args);
    static public void LogError(object message);
    static public void LogError(object message, Object context);
    static public void LogErrorFormat(string format, object[] args);
    static public void LogErrorFormat(Object context, string format, object[] args);
    static public void LogException(Exception exception);
    static public void LogException(Exception exception, Object context);
    static public void LogFormat(string format, object[] args);
    static public void LogFormat(Object context, string format, object[] args);
    static public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args);
    static public void LogWarning(object message);
    static public void LogWarning(object message, Object context);
    static public void LogWarningFormat(string format, object[] args);
    static public void LogWarningFormat(Object context, string format, object[] args);

    public Debug();

}

}
