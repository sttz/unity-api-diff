using System;
using UnityEngine;

namespace UnityEngine.TextCore.LowLevel
{

public sealed class FontEngine
{
    static public TextCore.LowLevel.FontEngineError DestroyFontEngine();
    static public TextCore.FaceInfo GetFaceInfo();
    static public TextCore.LowLevel.FontEngineError InitializeFontEngine();
    static public TextCore.LowLevel.FontEngineError LoadFontFace(string filePath);
    static public TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, int pointSize);
    static public TextCore.LowLevel.FontEngineError LoadFontFace(byte[] sourceFontFile);
    static public TextCore.LowLevel.FontEngineError LoadFontFace(byte[] sourceFontFile, int pointSize);
    static public TextCore.LowLevel.FontEngineError LoadFontFace(Font font);
    static public TextCore.LowLevel.FontEngineError LoadFontFace(Font font, int pointSize);
    static public TextCore.LowLevel.FontEngineError SetFaceSize(int pointSize);
    static public bool TryGetGlyphIndex(uint unicode, out uint glyphIndex);
    static public bool TryGetGlyphWithIndexValue(uint glyphIndex, TextCore.LowLevel.GlyphLoadFlags flags, out TextCore.Glyph glyph);
    static public bool TryGetGlyphWithUnicodeValue(uint unicode, TextCore.LowLevel.GlyphLoadFlags flags, out TextCore.Glyph glyph);

}

}
