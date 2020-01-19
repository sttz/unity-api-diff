using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUILayout
{
    static public void BeginArea(Rect screenRect);
    static public void BeginArea(Rect screenRect, GUIContent content);
    static public void BeginArea(Rect screenRect, Texture image);
    static public void BeginArea(Rect screenRect, GUIStyle style);
    static public void BeginArea(Rect screenRect, string text);
    static public void BeginArea(Rect screenRect, GUIContent content, GUIStyle style);
    static public void BeginArea(Rect screenRect, Texture image, GUIStyle style);
    static public void BeginArea(Rect screenRect, string text, GUIStyle style);
    static public void BeginHorizontal(GUILayoutOption[] options);
    static public void BeginHorizontal(GUIStyle style, GUILayoutOption[] options);
    static public void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public void BeginHorizontal(Texture image, GUIStyle style, GUILayoutOption[] options);
    static public void BeginHorizontal(string text, GUIStyle style, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options);
    static public void BeginVertical(GUILayoutOption[] options);
    static public void BeginVertical(GUIStyle style, GUILayoutOption[] options);
    static public void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public void BeginVertical(Texture image, GUIStyle style, GUILayoutOption[] options);
    static public void BeginVertical(string text, GUIStyle style, GUILayoutOption[] options);
    static public void Box(GUIContent content, GUILayoutOption[] options);
    static public void Box(Texture image, GUILayoutOption[] options);
    static public void Box(string text, GUILayoutOption[] options);
    static public void Box(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public void Box(Texture image, GUIStyle style, GUILayoutOption[] options);
    static public void Box(string text, GUIStyle style, GUILayoutOption[] options);
    static public bool Button(GUIContent content, GUILayoutOption[] options);
    static public bool Button(Texture image, GUILayoutOption[] options);
    static public bool Button(string text, GUILayoutOption[] options);
    static public bool Button(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public bool Button(Texture image, GUIStyle style, GUILayoutOption[] options);
    static public bool Button(string text, GUIStyle style, GUILayoutOption[] options);
    static public void EndArea();
    static public void EndHorizontal();
    static public void EndScrollView();
    static public void EndVertical();
    static public GUILayoutOption ExpandHeight(bool expand);
    static public GUILayoutOption ExpandWidth(bool expand);
    static public void FlexibleSpace();
    static public GUILayoutOption Height(float height);
    static public float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUILayoutOption[] options);
    static public float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, GUILayoutOption[] options);
    static public float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options);
    static public float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options);
    static public void Label(GUIContent content, GUILayoutOption[] options);
    static public void Label(Texture image, GUILayoutOption[] options);
    static public void Label(string text, GUILayoutOption[] options);
    static public void Label(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public void Label(Texture image, GUIStyle style, GUILayoutOption[] options);
    static public void Label(string text, GUIStyle style, GUILayoutOption[] options);
    static public GUILayoutOption MaxHeight(float maxHeight);
    static public GUILayoutOption MaxWidth(float maxWidth);
    static public GUILayoutOption MinHeight(float minHeight);
    static public GUILayoutOption MinWidth(float minWidth);
    static public string PasswordField(string password, char maskChar, GUILayoutOption[] options);
    static public string PasswordField(string password, char maskChar, int maxLength, GUILayoutOption[] options);
    static public string PasswordField(string password, char maskChar, GUIStyle style, GUILayoutOption[] options);
    static public string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, GUILayoutOption[] options);
    static public bool RepeatButton(GUIContent content, GUILayoutOption[] options);
    static public bool RepeatButton(Texture image, GUILayoutOption[] options);
    static public bool RepeatButton(string text, GUILayoutOption[] options);
    static public bool RepeatButton(GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public bool RepeatButton(Texture image, GUIStyle style, GUILayoutOption[] options);
    static public bool RepeatButton(string text, GUIStyle style, GUILayoutOption[] options);
    static public int SelectionGrid(int selected, GUIContent[] content, int xCount, GUILayoutOption[] options);
    static public int SelectionGrid(int selected, Texture[] images, int xCount, GUILayoutOption[] options);
    static public int SelectionGrid(int selected, string[] texts, int xCount, GUILayoutOption[] options);
    static public int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options);
    static public int SelectionGrid(int selected, Texture[] images, int xCount, GUIStyle style, GUILayoutOption[] options);
    static public int SelectionGrid(int selected, string[] texts, int xCount, GUIStyle style, GUILayoutOption[] options);
    static public void Space(float pixels);
    static public string TextArea(string text, GUILayoutOption[] options);
    static public string TextArea(string text, int maxLength, GUILayoutOption[] options);
    static public string TextArea(string text, GUIStyle style, GUILayoutOption[] options);
    static public string TextArea(string text, int maxLength, GUIStyle style, GUILayoutOption[] options);
    static public string TextField(string text, GUILayoutOption[] options);
    static public string TextField(string text, int maxLength, GUILayoutOption[] options);
    static public string TextField(string text, GUIStyle style, GUILayoutOption[] options);
    static public string TextField(string text, int maxLength, GUIStyle style, GUILayoutOption[] options);
    static public bool Toggle(bool value, GUIContent content, GUILayoutOption[] options);
    static public bool Toggle(bool value, Texture image, GUILayoutOption[] options);
    static public bool Toggle(bool value, string text, GUILayoutOption[] options);
    static public bool Toggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public bool Toggle(bool value, Texture image, GUIStyle style, GUILayoutOption[] options);
    static public bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options);
    static public int Toolbar(int selected, GUIContent[] contents, GUILayoutOption[] options);
    static public int Toolbar(int selected, Texture[] images, GUILayoutOption[] options);
    static public int Toolbar(int selected, string[] texts, GUILayoutOption[] options);
    static public int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUILayoutOption[] options);
    static public int Toolbar(int selected, Texture[] images, GUIStyle style, GUILayoutOption[] options);
    static public int Toolbar(int selected, string[] texts, GUIStyle style, GUILayoutOption[] options);
    static public int Toolbar(int selected, GUIContent[] contents, GUIStyle style, ToolbarButtonSize buttonSize, GUILayoutOption[] options);
    static public int Toolbar(int selected, Texture[] images, GUIStyle style, ToolbarButtonSize buttonSize, GUILayoutOption[] options);
    static public int Toolbar(int selected, string[] texts, GUIStyle style, ToolbarButtonSize buttonSize, GUILayoutOption[] options);
    static public float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUILayoutOption[] options);
    static public float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, GUILayoutOption[] options);
    static public float VerticalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options);
    static public float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options);
    static public GUILayoutOption Width(float width);
    static public Rect Window(int id, Rect screenRect, WindowFunction func, GUIContent content, GUILayoutOption[] options);
    static public Rect Window(int id, Rect screenRect, WindowFunction func, Texture image, GUILayoutOption[] options);
    static public Rect Window(int id, Rect screenRect, WindowFunction func, string text, GUILayoutOption[] options);
    static public Rect Window(int id, Rect screenRect, WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options);
    static public Rect Window(int id, Rect screenRect, WindowFunction func, Texture image, GUIStyle style, GUILayoutOption[] options);
    static public Rect Window(int id, Rect screenRect, WindowFunction func, string text, GUIStyle style, GUILayoutOption[] options);

    public GUILayout();

    public class AreaScope : Scope
    {
        public AreaScope(Rect screenRect);
        public AreaScope(Rect screenRect, GUIContent content);
        public AreaScope(Rect screenRect, Texture image);
        public AreaScope(Rect screenRect, string text);
        public AreaScope(Rect screenRect, GUIContent content, GUIStyle style);
        public AreaScope(Rect screenRect, Texture image, GUIStyle style);
        public AreaScope(Rect screenRect, string text, GUIStyle style);

        protected void CloseScope();

    }

    public class HorizontalScope : Scope
    {
        public HorizontalScope(GUILayoutOption[] options);
        public HorizontalScope(GUIStyle style, GUILayoutOption[] options);
        public HorizontalScope(GUIContent content, GUIStyle style, GUILayoutOption[] options);
        public HorizontalScope(Texture image, GUIStyle style, GUILayoutOption[] options);
        public HorizontalScope(string text, GUIStyle style, GUILayoutOption[] options);

        protected void CloseScope();

    }

    public class ScrollViewScope : Scope
    {
        public bool handleScrollWheel { get; set; }
        public Vector2 scrollPosition { get; private set; }

        public ScrollViewScope(Vector2 scrollPosition, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options);

        protected void CloseScope();

    }

    public class VerticalScope : Scope
    {
        public VerticalScope(GUILayoutOption[] options);
        public VerticalScope(GUIStyle style, GUILayoutOption[] options);
        public VerticalScope(GUIContent content, GUIStyle style, GUILayoutOption[] options);
        public VerticalScope(Texture image, GUIStyle style, GUILayoutOption[] options);
        public VerticalScope(string text, GUIStyle style, GUILayoutOption[] options);

        protected void CloseScope();

    }

}

}
