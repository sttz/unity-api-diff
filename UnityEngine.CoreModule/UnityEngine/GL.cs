using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GL
{
    static public int LINE_STRIP = 2;
    static public int LINES = 1;
    static public int QUADS = 7;
    static public int TRIANGLE_STRIP = 5;
    static public int TRIANGLES = 4;

    static public bool invertCulling { get; set; }
    static public Matrix4x4 modelview { get; set; }
    static public bool sRGBWrite { get; set; }
    static public bool wireframe { get; set; }

    static public void Begin(int mode);
    static public void Clear(bool clearDepth, bool clearColor, Color backgroundColor);
    static public void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth);
    static public void ClearWithSkybox(bool clearDepth, Camera camera);
    static public void Color(Color c);
    static public void End();
    static public void Flush();
    static public Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture);
    static public void InvalidateState();
    static public void IssuePluginEvent(int eventID);
    static public void IssuePluginEvent(IntPtr callback, int eventID);
    static public void LoadIdentity();
    static public void LoadOrtho();
    static public void LoadPixelMatrix();
    static public void LoadPixelMatrix(float left, float right, float bottom, float top);
    static public void LoadProjectionMatrix(Matrix4x4 mat);
    static public void MultiTexCoord(int unit, Vector3 v);
    static public void MultiTexCoord2(int unit, float x, float y);
    static public void MultiTexCoord3(int unit, float x, float y, float z);
    static public void MultMatrix(Matrix4x4 m);
    static public void PopMatrix();
    static public void PushMatrix();
    static public void RenderTargetBarrier();
    static public void SetRevertBackfacing(bool revertBackFaces);
    static public void TexCoord(Vector3 v);
    static public void TexCoord2(float x, float y);
    static public void TexCoord3(float x, float y, float z);
    static public void Vertex(Vector3 v);
    static public void Vertex3(float x, float y, float z);
    static public void Viewport(Rect pixelRect);

    public GL();

}

}
