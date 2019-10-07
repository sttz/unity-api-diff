using System;
using UnityEngine;

namespace UnityEngine
{

public interface ILogHandler
{
    public void LogException(Exception exception, Object context);
    public void LogFormat(LogType logType, Object context, string format, object[] args);

}

}
