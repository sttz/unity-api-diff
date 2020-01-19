using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public interface ILogger : ILogHandler
{
    public LogType filterLogType { get; set; }
    public bool logEnabled { get; set; }
    public ILogHandler logHandler { get; set; }

    public bool IsLogTypeAllowed(LogType logType);
    public void Log(object message);
    public void Log(LogType logType, object message);
    public void Log(string tag, object message);
    public void Log(LogType logType, object message, Object context);
    public void Log(LogType logType, string tag, object message);
    public void Log(string tag, object message, Object context);
    public void Log(LogType logType, string tag, object message, Object context);
    public void LogError(string tag, object message);
    public void LogError(string tag, object message, Object context);
    public void LogException(Exception exception);
    public void LogFormat(LogType logType, string format, object[] args);
    public void LogWarning(string tag, object message);
    public void LogWarning(string tag, object message, Object context);

}

}
