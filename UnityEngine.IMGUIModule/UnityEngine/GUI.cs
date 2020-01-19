using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUI
{
    static public Color backgroundColor { get; set; }
    static public bool changed { get; set; }
    static public Color color { get; set; }
    static public Color contentColor { get; set; }
    static public int depth { get; set; }
    static public bool enabled { get; set; }
    static public Matrix4x4 matrix { get; set; }
    static protected string mouseTooltip { get; }
    static public GUISkin skin { get; set; }
    static public string tooltip { get; set; }
    static protected Rect tooltipRect { get; set; }

    static public void BeginClip(Rect position);
    static public void BeginClip(Rect position, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset);
    static public void BeginGroup(Rect position);
    static public void BeginGroup(Rect position, GUIContent content);
    static public void BeginGroup(Rect position, Texture image);
    static public void BeginGroup(Rect position, GUIStyle style);
    static public void BeginGroup(Rect position, string text);
    static public void BeginGroup(Rect position, GUIContent content, GUIStyle style);
    static public void BeginGroup(Rect position, Texture image, GUIStyle style);
    static public void BeginGroup(Rect position, string text, GUIStyle style);
    static public Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect);
    static public Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical);
    static public Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);
    static public Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);
    static public void Box(Rect position, GUIContent content);
    static public void Box(Rect position, Texture image);
    static public void Box(Rect position, string text);
    static public void Box(Rect position, GUIContent content, GUIStyle style);
    static public void Box(Rect position, Texture image, GUIStyle style);
    static public void Box(Rect position, string text, GUIStyle style);
    static public void BringWindowToBack(int windowID);
    static public void BringWindowToFront(int windowID);
    static public bool Button(Rect position, GUIContent content);
    static public bool Button(Rect position, Texture image);
    static public bool Button(Rect position, string text);
    static public bool Button(Rect position, GUIContent content, GUIStyle style);
    static public bool Button(Rect position, Texture image, GUIStyle style);
    static public bool Button(Rect position, string text, GUIStyle style);
    static protected Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background);
    static public void DragWindow();
    static public void DragWindow(Rect position);
    static public void DrawTexture(Rect position, Texture image);
    static public void DrawTexture(Rect position, Texture image, ScaleMode scaleMode);
    static public void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend);
    static public void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect);
    static public void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius);
    static public void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius);
    static public void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses);
    static public void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords);
    static public void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend);
    static public void EndClip();
    static public void EndGroup();
    static public void EndScrollView();
    static public void EndScrollView(bool handleScrollWheel);
    static public void FocusControl(string name);
    static public void FocusWindow(int windowID);
    static public string GetNameOfFocusedControl();
    static public float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue);
    static public float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style);
    static public float HorizontalSlider(Rect position, float value, float leftValue, float rightValue);
    static public float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb);
    static public void Label(Rect position, GUIContent content);
    static public void Label(Rect position, Texture image);
    static public void Label(Rect position, string text);
    static public void Label(Rect position, GUIContent content, GUIStyle style);
    static public void Label(Rect position, Texture image, GUIStyle style);
    static public void Label(Rect position, string text, GUIStyle style);
    static public Rect ModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content);
    static public Rect ModalWindow(int id, Rect clientRect, WindowFunction func, Texture image);
    static public Rect ModalWindow(int id, Rect clientRect, WindowFunction func, string text);
    static public Rect ModalWindow(int id, Rect clientRect, WindowFunction func, GUIContent content, GUIStyle style);
    static public Rect ModalWindow(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style);
    static public Rect ModalWindow(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style);
    static public string PasswordField(Rect position, string password, char maskChar);
    static public string PasswordField(Rect position, string password, char maskChar, int maxLength);
    static public string PasswordField(Rect position, string password, char maskChar, GUIStyle style);
    static public string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style);
    static public bool RepeatButton(Rect position, GUIContent content);
    static public bool RepeatButton(Rect position, Texture image);
    static public bool RepeatButton(Rect position, string text);
    static public bool RepeatButton(Rect position, GUIContent content, GUIStyle style);
    static public bool RepeatButton(Rect position, Texture image, GUIStyle style);
    static public bool RepeatButton(Rect position, string text, GUIStyle style);
    static public void ScrollTo(Rect position);
    static public bool ScrollTowards(Rect position, float maxDelta);
    static public int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount);
    static public int SelectionGrid(Rect position, int selected, Texture[] images, int xCount);
    static public int SelectionGrid(Rect position, int selected, string[] texts, int xCount);
    static public int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style);
    static public int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style);
    static public int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style);
    static public void SetNextControlName(string name);
    static public float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id);
    static public string TextArea(Rect position, string text);
    static public string TextArea(Rect position, string text, int maxLength);
    static public string TextArea(Rect position, string text, GUIStyle style);
    static public string TextArea(Rect position, string text, int maxLength, GUIStyle style);
    static public string TextField(Rect position, string text);
    static public string TextField(Rect position, string text, int maxLength);
    static public string TextField(Rect position, string text, GUIStyle style);
    static public string TextField(Rect position, string text, int maxLength, GUIStyle style);
    static public bool Toggle(Rect position, bool value, GUIContent content);
    static public bool Toggle(Rect position, bool value, Texture image);
    static public bool Toggle(Rect position, bool value, string text);
    static public bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style);
    static public bool Toggle(Rect position, bool value, Texture image, GUIStyle style);
    static public bool Toggle(Rect position, bool value, string text, GUIStyle style);
    static public bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style);
    static public int Toolbar(Rect position, int selected, GUIContent[] contents);
    static public int Toolbar(Rect position, int selected, Texture[] images);
    static public int Toolbar(Rect position, int selected, string[] texts);
    static public int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style);
    static public int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style);
    static public int Toolbar(Rect position, int selected, string[] texts, GUIStyle style);
    static public int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style, ToolbarButtonSize buttonSize);
    static public void UnfocusWindow();
    static public float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue);
    static public float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style);
    static public float VerticalSlider(Rect position, float value, float topValue, float bottomValue);
    static public float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb);
    static public Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent content);
    static public Rect Window(int id, Rect clientRect, WindowFunction func, Texture image);
    static public Rect Window(int id, Rect clientRect, WindowFunction func, string text);
    static public Rect Window(int id, Rect clientRect, WindowFunction func, Texture image, GUIStyle style);
    static public Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style);
    static public Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style);

    public GUI();

    public class ClipScope : Scope
    {
        public ClipScope(Rect position);

        protected void CloseScope();

    }

    public class GroupScope : Scope
    {
        public GroupScope(Rect position);
        public GroupScope(Rect position, GUIContent content);
        public GroupScope(Rect position, Texture image);
        public GroupScope(Rect position, GUIStyle style);
        public GroupScope(Rect position, string text);
        public GroupScope(Rect position, Texture image, GUIStyle style);
        public GroupScope(Rect position, string text, GUIStyle style);

        protected void CloseScope();

    }

    public abstract class Scope : IDisposable
    {
        protected Scope();

        protected void CloseScope();
        public void Dispose();

    }

    public class ScrollViewScope : Scope
    {
        public bool handleScrollWheel { get; set; }
        public Vector2 scrollPosition { get; private set; }

        public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect);
        public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical);
        public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);
        public ScrollViewScope(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar);

        protected void CloseScope();

    }

    public enum ToolbarButtonSize
    {
        Fixed = 0,
        FitToContents = 1,
    }

    public delegate void WindowFunction(int id);

}

}
