using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.WebCam
{

public sealed class PhotoCaptureFrame : IDisposable
{
    public int dataLength { get; private set; }
    public bool hasLocationData { get; private set; }
    public XR.WSA.WebCam.CapturePixelFormat pixelFormat { get; private set; }

    public void CopyRawImageDataIntoBuffer(System.Collections.Generic.List<byte> byteBuffer);
    public void Dispose();
    public IntPtr GetUnsafePointerToBuffer();
    public bool TryGetCameraToWorldMatrix(out Matrix4x4 cameraToWorldMatrix);
    public bool TryGetProjectionMatrix(out Matrix4x4 projectionMatrix);
    public bool TryGetProjectionMatrix(float nearClipPlane, float farClipPlane, out Matrix4x4 projectionMatrix);
    public void UploadImageDataToTexture(Texture2D targetTexture);

}

}
