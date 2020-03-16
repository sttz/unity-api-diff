using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.MPE
{

public class ProcessService
{
    static public Unity.MPE.ProcessLevel level { get; }
    static public string roleName { get; }

    static public event SlaveProcessExitedHandler SlaveProcessExitedEvent;

    static public void ApplyPropertyModifications(UnityEditor.PropertyModification[] modifications);
    static public Object DeserializeObject(byte[] bytes);
    static public void DisableProfileConnection();
    static public int EnableProfileConnection(string dataPath);
    static public Unity.MPE.ProcessState GetSlaveProcessState(int pid);
    static public bool HasCapability(string capName);
    static public bool IsChannelServiceStarted();
    static public int LaunchSlave(string roleName, string[] keyValuePairs);
    static public string ReadParameter(string paramName);
    static public byte[] SerializeObject(int instanceId);
    static public void TerminateSlave(int pid);

    public ProcessService();

    public delegate void SlaveProcessExitedHandler(int pid, Unity.MPE.ProcessState newState);

}

}
