using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Gizmos
{
    static public Color color { get; set; }
    static public Texture exposure { get; set; }
    static public Matrix4x4 matrix { get; set; }

    static public void DrawCube(Vector3 center, Vector3 size);
    static public void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect);
    static public void DrawGUITexture(Rect screenRect, Texture texture);
    static public void DrawGUITexture(Rect screenRect, Texture texture, Material mat);
    static public void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder);
    static public void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat);
    static public void DrawIcon(Vector3 center, string name);
    static public void DrawIcon(Vector3 center, string name, bool allowScaling);
    static public void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint);
    static public void DrawLine(Vector3 from, Vector3 to);
    static public void DrawMesh(Mesh mesh);
    static public void DrawMesh(Mesh mesh, Vector3 position);
    static public void DrawMesh(Mesh mesh, int submeshIndex);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation);
    static public void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale);
    static public void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation);
    static public void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale);
    static public void DrawRay(Ray r);
    static public void DrawRay(Vector3 from, Vector3 direction);
    static public void DrawSphere(Vector3 center, float radius);
    static public void DrawWireCube(Vector3 center, Vector3 size);
    static public void DrawWireMesh(Mesh mesh);
    static public void DrawWireMesh(Mesh mesh, Vector3 position);
    static public void DrawWireMesh(Mesh mesh, int submeshIndex);
    static public void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation);
    static public void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position);
    static public void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale);
    static public void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation);
    static public void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale);
    static public void DrawWireSphere(Vector3 center, float radius);

    public Gizmos();

}

}
