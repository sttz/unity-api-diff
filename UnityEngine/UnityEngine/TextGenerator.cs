using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class TextGenerator : IDisposable
{
    public int characterCount { get; }
    public int characterCountVisible { get; }
    public System.Collections.Generic.IList<UICharInfo> characters { get; }
    public int fontSizeUsedForBestFit { get; }
    public int lineCount { get; }
    public System.Collections.Generic.IList<UILineInfo> lines { get; }
    public Rect rectExtents { get; }
    public int vertexCount { get; }
    public System.Collections.Generic.IList<UIVertex> verts { get; }

    public TextGenerator();
    public TextGenerator(int initialCapacity);

    public void GetCharacters(System.Collections.Generic.List<UICharInfo> characters);
    public UICharInfo[] GetCharactersArray();
    public void GetLines(System.Collections.Generic.List<UILineInfo> lines);
    public UILineInfo[] GetLinesArray();
    public float GetPreferredHeight(string str, TextGenerationSettings settings);
    public float GetPreferredWidth(string str, TextGenerationSettings settings);
    public void GetVertices(System.Collections.Generic.List<UIVertex> vertices);
    public UIVertex[] GetVerticesArray();
    public void Invalidate();
    public bool Populate(string str, TextGenerationSettings settings);
    public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context);

}

}
