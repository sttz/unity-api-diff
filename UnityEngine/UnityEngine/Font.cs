using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Font : Object
{
    static public event Action<Font> textureRebuilt;

    static public Font CreateDynamicFontFromOSFont(string fontname, int size);
    static public Font CreateDynamicFontFromOSFont(string[] fontnames, int size);
    static public int GetMaxVertsForString(string str);
    static public string[] GetOSInstalledFontNames();
    static public string[] GetPathsToOSFonts();

    public int ascent { get; }
    public CharacterInfo[] characterInfo { get; set; }
    public bool dynamic { get; }
    public string[] fontNames { get; set; }
    public int fontSize { get; }
    public int lineHeight { get; }
    public Material material { get; set; }
    public FontTextureRebuildCallback textureRebuildCallback { get; set; }

    public Font();
    public Font(string name);

    public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style);
    public bool GetCharacterInfo(char ch, out CharacterInfo info, int size);
    public bool GetCharacterInfo(char ch, out CharacterInfo info);
    public bool HasCharacter(char c);
    public void RequestCharactersInTexture(string characters, int size, FontStyle style);
    public void RequestCharactersInTexture(string characters, int size);
    public void RequestCharactersInTexture(string characters);

    public delegate void FontTextureRebuildCallback();

}

}
