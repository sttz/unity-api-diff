using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public class ProcessService
{
    static public UnityEditor.MPE.ProcessLevel level { get; }
    static public string roleName { get; }

    static public event Action<int, UnityEditor.MPE.ProcessState> SlaveProcessExitedEvent;

    static public void ApplyPropertyModifications(UnityEditor.PropertyModification[] modifications);
    static public Object DeserializeObject(byte[] bytes);
    static public void DisableProfileConnection();
    static public int EnableProfileConnection(string dataPath);
    static public UnityEditor.MPE.ProcessState GetSlaveProcessState(int pid);
    static public bool HasCapability(string capName);
    static public bool IsChannelServiceStarted();
    static public int LaunchSlave(string roleName, string[] keyValuePairs);
    static public string ReadParameter(string paramName);
    static public byte[] SerializeObject(int instanceId);
    static public void TerminateSlave(int pid);

    public ProcessService();

}

}
