using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class L10n
{
    static public GUIContent IconContent(Texture icon, string tooltip = null);
    static public GUIContent IconContent(string iconName, string tooltip = null);
    static public GUIContent TempContent(string t);
    static public GUIContent[] TempContent(string[] texts);
    static public GUIContent[] TempContent(string[] texts, string[] tooltips);
    static public GUIContent TextContent(string text, Texture icon);
    static public GUIContent TextContent(string text, string tooltip = null, Texture icon = null);
    static public GUIContent TextContent(string text, string tooltip, string iconName);
    static public GUIContent TextContentWithIcon(string text, Texture icon);
    static public GUIContent TextContentWithIcon(string text, string iconName);
    static public GUIContent TextContentWithIcon(string text, UnityEditor.MessageType messageType);
    static public GUIContent TextContentWithIcon(string text, string tooltip, Texture icon);
    static public GUIContent TextContentWithIcon(string text, string tooltip, string iconName);
    static public GUIContent TextContentWithIcon(string text, string tooltip, UnityEditor.MessageType messageType);
    static public string Tr(string str);
    static public string[] Tr(string[] str_list);
    static public string Tr(string str, string groupName);
    static public string TrPath(string path);

}

}
