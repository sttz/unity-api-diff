using System;
using UnityEngine;

namespace UnityEngine.Windows.WebCam
{

public class PhotoCapture : IDisposable
{
    static public System.Collections.Generic.IEnumerable<Resolution> SupportedResolutions { get; }

    static public void CreateAsync(bool showHolograms, OnCaptureResourceCreatedCallback onCreatedCallback);
    static public void CreateAsync(OnCaptureResourceCreatedCallback onCreatedCallback);

    public void Dispose();
    public IntPtr GetUnsafePointerToVideoDeviceController();
    public void StartPhotoModeAsync(Windows.WebCam.CameraParameters setupParams, OnPhotoModeStartedCallback onPhotoModeStartedCallback);
    public void StopPhotoModeAsync(OnPhotoModeStoppedCallback onPhotoModeStoppedCallback);
    public void TakePhotoAsync(string filename, Windows.WebCam.PhotoCaptureFileOutputFormat fileOutputFormat, OnCapturedToDiskCallback onCapturedPhotoToDiskCallback);
    public void TakePhotoAsync(OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback);

    public enum CaptureResultType
    {
        Success = 0,
        UnknownError = 1,
    }

    public struct PhotoCaptureResult
    {
        public long hResult;
        public CaptureResultType resultType;

        public bool success { get; }

    }

    public delegate void OnCaptureResourceCreatedCallback(Windows.WebCam.PhotoCapture captureObject);

    public delegate void OnPhotoModeStartedCallback(PhotoCaptureResult result);

    public delegate void OnPhotoModeStoppedCallback(PhotoCaptureResult result);

    public delegate void OnCapturedToDiskCallback(PhotoCaptureResult result);

    public delegate void OnCapturedToMemoryCallback(PhotoCaptureResult result, Windows.WebCam.PhotoCaptureFrame photoCaptureFrame);

}

}
