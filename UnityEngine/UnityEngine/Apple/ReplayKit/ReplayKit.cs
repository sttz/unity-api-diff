using System;
using UnityEngine;

namespace UnityEngine.Apple.ReplayKit
{

public static class ReplayKit
{
    static public bool APIAvailable { get; }
    static public bool broadcastingAPIAvailable { get; }
    static public string broadcastURL { get; }
    static public bool cameraEnabled { get; set; }
    static public bool isBroadcasting { get; }
    static public bool isBroadcastingPaused { get; }
    static public bool isPreviewControllerActive { get; }
    static public bool isRecording { get; }
    static public string lastError { get; }
    static public bool microphoneEnabled { get; set; }
    static public bool recordingAvailable { get; }

    static public bool Discard();
    static public void HideCameraPreview();
    static public void PauseBroadcasting();
    static public bool Preview();
    static public void ResumeBroadcasting();
    static public bool ShowCameraPreviewAt(float posX, float posY);
    static public bool ShowCameraPreviewAt(float posX, float posY, float width, float height);
    static public void StartBroadcasting(BroadcastStatusCallback callback, bool enableMicrophone, bool enableCamera);
    static public void StartBroadcasting(BroadcastStatusCallback callback, bool enableMicrophone);
    static public void StartBroadcasting(BroadcastStatusCallback callback);
    static public bool StartRecording(bool enableMicrophone, bool enableCamera);
    static public bool StartRecording(bool enableMicrophone);
    static public bool StartRecording();
    static public void StopBroadcasting();
    static public bool StopRecording();

    public delegate void BroadcastStatusCallback(bool hasStarted, string errorMessage);

}

}
