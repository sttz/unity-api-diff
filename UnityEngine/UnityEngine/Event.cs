using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Event
{
    static public Event current { get; set; }

    static public int GetEventCount();
    static public Event KeyboardEvent(string key);
    static public bool PopEvent(Event outEvent);

    public bool alt { get; set; }
    public int button { get; set; }
    public bool capsLock { get; set; }
    public char character { get; set; }
    public int clickCount { get; set; }
    public bool command { get; set; }
    public string commandName { get; set; }
    public bool control { get; set; }
    public Vector2 delta { get; set; }
    public int displayIndex { get; set; }
    public bool functionKey { get; }
    public bool isKey { get; }
    public bool isMouse { get; }
    public bool isScrollWheel { get; }
    public KeyCode keyCode { get; set; }
    public EventModifiers modifiers { get; set; }
    public Vector2 mousePosition { get; set; }
    public Ray mouseRay { get; set; }
    public bool numeric { get; set; }
    public PointerType pointerType { get; set; }
    public float pressure { get; set; }
    public EventType rawType { get; }
    public bool shift { get; set; }
    public EventType type { get; set; }

    public Event();
    public Event(int displayIndex);
    public Event(Event other);

    public bool Equals(object obj);
    public int GetHashCode();
    public EventType GetTypeForControl(int controlID);
    public string ToString();
    public void Use();

}

}
