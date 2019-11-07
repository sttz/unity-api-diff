using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class Handles
{
    static public Color centerColor { get; }
    static public Color color { get; set; }
    static public Matrix4x4 inverseMatrix { get; }
    static public bool lighting { get; set; }
    static public Matrix4x4 matrix { get; set; }
    static public Color preselectionColor { get; }
    static public Color secondaryColor { get; }
    static public Color selectedColor { get; }
    static public Color xAxisColor { get; }
    static public Color yAxisColor { get; }
    static public Color zAxisColor { get; }
    static public Rendering.CompareFunction zTest { get; set; }

    static public void ArrowCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void ArrowHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public void BeginGUI();
    static public void BeginGUI(Rect position);
    static public bool Button(Vector3 position, Quaternion direction, float size, float pickSize, CapFunction capFunction);
    static public bool Button(Vector3 position, Quaternion direction, float size, float pickSize, DrawCapFunction capFunc);
    static public void CircleCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void CircleHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public void ClearCamera(Rect position, Camera camera);
    static public void ConeCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void ConeHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public void CubeCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void CubeHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public void CylinderCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void CylinderHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public Quaternion Disc(int id, Quaternion rotation, Vector3 position, Vector3 axis, float size, bool cutoffPlane, float snap);
    static public Quaternion Disc(Quaternion rotation, Vector3 position, Vector3 axis, float size, bool cutoffPlane, float snap);
    static public Vector3 DoPositionHandle(Vector3 position, Quaternion rotation);
    static public Quaternion DoRotationHandle(Quaternion rotation, Vector3 position);
    static public Vector3 DoScaleHandle(Vector3 scale, Vector3 position, Quaternion rotation, float size);
    static public void DotCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DotHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public void DrawAAConvexPolygon(Vector3[] points);
    static public void DrawAAPolyLine(Vector3[] points);
    static public void DrawAAPolyLine(float width, Vector3[] points);
    static public void DrawAAPolyLine(Texture2D lineTex, Vector3[] points);
    static public void DrawAAPolyLine(float width, int actualNumberOfPoints, Vector3[] points);
    static public void DrawAAPolyLine(Texture2D lineTex, float width, Vector3[] points);
    static public void DrawArrow(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DrawBezier(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, Color color, Texture2D texture, float width);
    static public void DrawCamera(Rect position, Camera camera);
    static public void DrawCamera(Rect position, Camera camera, UnityEditor.DrawCameraMode drawMode);
    static public void DrawCone(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DrawCube(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DrawCylinder(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DrawDottedLine(Vector3 p1, Vector3 p2, float screenSpaceSize);
    static public void DrawDottedLines(Vector3[] lineSegments, float screenSpaceSize);
    static public void DrawDottedLines(Vector3[] points, int[] segmentIndices, float screenSpaceSize);
    static public void DrawGizmos(Camera camera);
    static public void DrawLine(Vector3 p1, Vector3 p2);
    static public void DrawLines(Vector3[] lineSegments);
    static public void DrawLines(Vector3[] points, int[] segmentIndices);
    static public void DrawPolyLine(Vector3[] points);
    static public void DrawRectangle(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DrawSelectionFrame(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public void DrawSolidArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
    static public void DrawSolidDisc(Vector3 center, Vector3 normal, float radius);
    static public void DrawSolidRectangleWithOutline(Rect rectangle, Color faceColor, Color outlineColor);
    static public void DrawSolidRectangleWithOutline(Vector3[] verts, Color faceColor, Color outlineColor);
    static public void DrawSphere(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void DrawWireArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius);
    static public void DrawWireCube(Vector3 center, Vector3 size);
    static public void DrawWireDisc(Vector3 center, Vector3 normal, float radius);
    static public void EndGUI();
    static public Vector3 FreeMoveHandle(Vector3 position, Quaternion rotation, float size, Vector3 snap, CapFunction capFunction);
    static public Vector3 FreeMoveHandle(int controlID, Vector3 position, Quaternion rotation, float size, Vector3 snap, CapFunction capFunction);
    static public Vector3 FreeMoveHandle(Vector3 position, Quaternion rotation, float size, Vector3 snap, DrawCapFunction capFunc);
    static public Quaternion FreeRotateHandle(int id, Quaternion rotation, Vector3 position, float size);
    static public Quaternion FreeRotateHandle(Quaternion rotation, Vector3 position, float size);
    static public Vector2 GetMainGameViewSize();
    static public void Label(Vector3 position, string text);
    static public void Label(Vector3 position, Texture image);
    static public void Label(Vector3 position, GUIContent content);
    static public void Label(Vector3 position, string text, GUIStyle style);
    static public void Label(Vector3 position, GUIContent content, GUIStyle style);
    static public Vector3[] MakeBezierPoints(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, int division);
    static public Vector3 PositionHandle(Vector3 position, Quaternion rotation);
    static public float RadiusHandle(Quaternion rotation, Vector3 position, float radius, bool handlesOnly);
    static public float RadiusHandle(Quaternion rotation, Vector3 position, float radius);
    static public void RectangleCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void RectangleHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
    static public Quaternion RotationHandle(Quaternion rotation, Vector3 position);
    static public Vector3 ScaleHandle(Vector3 scale, Vector3 position, Quaternion rotation, float size);
    static public float ScaleSlider(float scale, Vector3 position, Vector3 direction, Quaternion rotation, float size, float snap);
    static public float ScaleValueHandle(float value, Vector3 position, Quaternion rotation, float size, CapFunction capFunction, float snap);
    static public float ScaleValueHandle(int controlID, float value, Vector3 position, Quaternion rotation, float size, CapFunction capFunction, float snap);
    static public float ScaleValueHandle(float value, Vector3 position, Quaternion rotation, float size, DrawCapFunction capFunc, float snap);
    static public void SelectionFrame(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void SetCamera(Camera camera);
    static public void SetCamera(Rect position, Camera camera);
    static public Vector3 Slider(Vector3 position, Vector3 direction);
    static public Vector3 Slider(Vector3 position, Vector3 direction, float size, CapFunction capFunction, float snap);
    static public Vector3 Slider(int controlID, Vector3 position, Vector3 direction, float size, CapFunction capFunction, float snap);
    static public Vector3 Slider(int controlID, Vector3 position, Vector3 offset, Vector3 direction, float size, CapFunction capFunction, float snap);
    static public Vector3 Slider(Vector3 position, Vector3 direction, float size, DrawCapFunction drawFunc, float snap);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 offset, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 offset, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap, bool drawHelper);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 offset, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, Vector2 snap);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 offset, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, Vector2 snap, bool drawHelper);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap, bool drawHelper);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, Vector2 snap);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, Vector2 snap, bool drawHelper);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, Vector2 snap, bool drawHelper);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, Vector2 snap);
    static public Vector3 Slider2D(int id, Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, Vector2 snap, bool drawHelper);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, float snap);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, CapFunction capFunction, float snap, bool drawHelper);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, float snap);
    static public Vector3 Slider2D(Vector3 handlePos, Vector3 handleDir, Vector3 slideDir1, Vector3 slideDir2, float handleSize, DrawCapFunction drawFunc, float snap, bool drawHelper);
    static public float SnapValue(float val, float snap);
    static public void SphereCap(int controlID, Vector3 position, Quaternion rotation, float size);
    static public void SphereHandleCap(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);

    public Camera currentCamera { get; set; }

    public Handles();

    public struct DrawingScope : IDisposable
    {
        public Color originalColor { get; }
        public Matrix4x4 originalMatrix { get; }

        public DrawingScope(Color color);
        public DrawingScope(Matrix4x4 matrix);
        public DrawingScope(Color color, Matrix4x4 matrix);

        public void Dispose();

    }

    public delegate void CapFunction(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);

    public delegate void DrawCapFunction(int controlID, Vector3 position, Quaternion rotation, float size);

    public delegate float SizeFunction(Vector3 position);

}

}
