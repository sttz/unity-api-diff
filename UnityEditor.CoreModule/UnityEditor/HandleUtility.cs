using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class HandleUtility
{
    static public float acceleration { get; }
    static public Material handleMaterial { get; }
    static public int nearestControl { get; set; }
    static public float niceMouseDelta { get; }
    static public float niceMouseDeltaZoom { get; }

    static public event PickGameObjectCallback pickGameObjectCustomPasses;
    static public event PlaceObjectDelegate placeObjectCustomPasses;

    static public void AddControl(int controlId, float distance);
    static public void AddDefaultControl(int controlId);
    static public float CalcLineTranslation(Vector2 src, Vector2 dest, Vector3 srcPosition, Vector3 constraintDir);
    static public Vector3 ClosestPointToArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
    static public Vector3 ClosestPointToDisc(Vector3 center, Vector3 normal, float radius);
    static public Vector3 ClosestPointToPolyLine(Vector3[] vertices);
    static public float DistancePointBezier(Vector3 point, Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent);
    static public float DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd);
    static public float DistancePointToLine(Vector2 p, Vector2 a, Vector2 b);
    static public float DistancePointToLineSegment(Vector2 p, Vector2 a, Vector2 b);
    static public float DistanceToArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
    static public float DistanceToCircle(Vector3 position, float radius);
    static public float DistanceToCone(Vector3 position, Quaternion rotation, float size);
    static public float DistanceToCube(Vector3 position, Quaternion rotation, float size);
    static public float DistanceToDisc(Vector3 center, Vector3 normal, float radius);
    static public float DistanceToLine(Vector3 p1, Vector3 p2);
    static public float DistanceToPolyLine(Vector3[] points);
    static public float DistanceToRectangle(Vector3 position, Quaternion rotation, float size);
    static public bool FindNearestVertex(Vector2 guiPoint, out Vector3 vertex);
    static public bool FindNearestVertex(Vector2 guiPoint, Transform[] objectsToSearch, out Vector3 vertex);
    static public bool FindNearestVertex(Vector2 guiPoint, Transform[] objectsToSearch, Transform[] objectsToIgnore, out Vector3 vertex);
    static public float GetHandleSize(Vector3 position);
    static public Vector2 GUIPointToScreenPixelCoordinate(Vector2 guiPoint);
    static public Ray GUIPointToWorldRay(Vector2 position);
    static public GameObject PickGameObject(Vector2 position, out int materialIndex);
    static public GameObject PickGameObject(Vector2 position, bool selectPrefabRoot);
    static public GameObject PickGameObject(Vector2 position, GameObject[] ignore, out int materialIndex);
    static public GameObject PickGameObject(Vector2 position, bool selectPrefabRoot, GameObject[] ignore);
    static public GameObject PickGameObject(Vector2 position, GameObject[] ignore, GameObject[] selection, out int materialIndex);
    static public GameObject PickGameObject(Vector2 position, bool selectPrefabRoot, GameObject[] ignore, GameObject[] filter);
    static public GameObject PickGameObject(Vector2 position, bool selectPrefabRoot, GameObject[] ignore, GameObject[] filter, out int materialIndex);
    static public GameObject[] PickRectObjects(Rect rect);
    static public GameObject[] PickRectObjects(Rect rect, bool selectPrefabRootsOnly);
    static public bool PlaceObject(Vector2 guiPosition, out Vector3 position, out Vector3 normal);
    static public float PointOnLineParameter(Vector3 point, Vector3 linePoint, Vector3 lineDirection);
    static public void PopCamera(Camera camera);
    static public Vector3 ProjectPointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd);
    static public void PushCamera(Camera camera);
    static public object RaySnap(Ray ray);
    static public void Repaint();
    static public Rect WorldPointToSizedRect(Vector3 position, GUIContent content, GUIStyle style);
    static public Vector2 WorldToGUIPoint(Vector3 world);
    static public Vector3 WorldToGUIPointWithDepth(Vector3 world);

    public HandleUtility();

    public delegate GameObject PickGameObjectCallback(Camera cam, int layers, Vector2 position, GameObject[] ignore, GameObject[] filter, out int materialIndex);

    public delegate bool PlaceObjectDelegate(Vector2 guiPosition, out Vector3 position, out Vector3 normal);

}

}
