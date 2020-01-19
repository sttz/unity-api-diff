using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TextGenerator : IDisposable
{
    public int characterCount { get; }
    public int characterCountVisible { get; }
    public IList<UICharInfo> characters { get; }
    public int fontSizeUsedForBestFit { get; }
    public int lineCount { get; }
    public IList<UILineInfo> lines { get; }
    public Rect rectExtents { get; }
    public int vertexCount { get; }
    public IList<UIVertex> verts { get; }

    public TextGenerator();
    public TextGenerator(int initialCapacity);

    public void GetCharacters(List<UICharInfo> characters);
    public UICharInfo[] GetCharactersArray();
    public void GetLines(List<UILineInfo> lines);
    public UILineInfo[] GetLinesArray();
    public float GetPreferredHeight(string str, TextGenerationSettings settings);
    public float GetPreferredWidth(string str, TextGenerationSettings settings);
    public void GetVertices(List<UIVertex> vertices);
    public UIVertex[] GetVerticesArray();
    public void Invalidate();
    public bool Populate(string str, TextGenerationSettings settings);
    public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context);

}

}
