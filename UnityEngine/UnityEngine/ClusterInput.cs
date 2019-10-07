using System;
using UnityEngine;

namespace UnityEngine
{

public class ClusterInput
{
    static public bool AddInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type);
    static public bool CheckConnectionToServer(string name);
    static public bool EditInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type);
    static public float GetAxis(string name);
    static public bool GetButton(string name);
    static public Vector3 GetTrackerPosition(string name);
    static public Quaternion GetTrackerRotation(string name);
    static public void SetAxis(string name, float value);
    static public void SetButton(string name, bool value);
    static public void SetTrackerPosition(string name, Vector3 value);
    static public void SetTrackerRotation(string name, Quaternion value);

    public ClusterInput();

}

}
