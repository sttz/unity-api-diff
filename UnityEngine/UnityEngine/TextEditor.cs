using System;
using UnityEngine;

namespace UnityEngine
{

public class TextEditor
{
    public int controlID;
    public Vector2 graphicalCursorPos;
    public Vector2 graphicalSelectCursorPos;
    public bool hasHorizontalCursorPos;
    public bool isPasswordField;
    public TouchScreenKeyboard keyboardOnScreen;
    public bool multiline;
    public Vector2 scrollOffset;
    public GUIStyle style;

    public int altCursorPosition { get; set; }
    public GUIContent content { get; set; }
    public int cursorIndex { get; set; }
    public DblClickSnapping doubleClickSnapping { get; set; }
    public bool hasSelection { get; }
    public Rect position { get; set; }
    public string SelectedText { get; }
    public int selectIndex { get; set; }
    public string text { get; set; }

    public TextEditor();

    public bool Backspace();
    public bool CanPaste();
    public void Copy();
    public bool Cut();
    public void DblClickSnap(DblClickSnapping snapping);
    public bool Delete();
    public bool DeleteLineBack();
    public bool DeleteSelection();
    public bool DeleteWordBack();
    public bool DeleteWordForward();
    public void DetectFocusChange();
    public void DrawCursor(string newText);
    public void ExpandSelectGraphicalLineEnd();
    public void ExpandSelectGraphicalLineStart();
    public int FindStartOfNextWord(int p);
    public bool HandleKeyEvent(Event e);
    public void Insert(char c);
    public bool IsOverSelection(Vector2 cursorPosition);
    public void MouseDragSelectsWholeWords(bool on);
    public void MoveAltCursorToPosition(Vector2 cursorPosition);
    public void MoveCursorToPosition(Vector2 cursorPosition);
    public void MoveDown();
    public void MoveGraphicalLineEnd();
    public void MoveGraphicalLineStart();
    public void MoveLeft();
    public void MoveLineEnd();
    public void MoveLineStart();
    public void MoveParagraphBackward();
    public void MoveParagraphForward();
    public void MoveRight();
    public void MoveSelectionToAltCursor();
    public void MoveTextEnd();
    public void MoveTextStart();
    public void MoveToEndOfPreviousWord();
    public void MoveToStartOfNextWord();
    public void MoveUp();
    public void MoveWordLeft();
    public void MoveWordRight();
    public void OnFocus();
    public void OnLostFocus();
    public bool Paste();
    public void ReplaceSelection(string replace);
    public void SaveBackup();
    public void SelectAll();
    public void SelectCurrentParagraph();
    public void SelectCurrentWord();
    public void SelectDown();
    public void SelectGraphicalLineEnd();
    public void SelectGraphicalLineStart();
    public void SelectLeft();
    public void SelectNone();
    public void SelectParagraphBackward();
    public void SelectParagraphForward();
    public void SelectRight();
    public void SelectTextEnd();
    public void SelectTextStart();
    public void SelectToEndOfPreviousWord();
    public void SelectToPosition(Vector2 cursorPosition);
    public void SelectToStartOfNextWord();
    public void SelectUp();
    public void SelectWordLeft();
    public void SelectWordRight();
    public void Undo();
    public void UpdateScrollOffsetIfNeeded(Event evt);

    public enum DblClickSnapping : byte
    {
        WORDS = 0,
        PARAGRAPHS = 1,
    }

}

}
