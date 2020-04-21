using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TextureAtlas
{
    public int atlasHeight;
    public int atlasPadding;
    public int atlasWidth;
    public List<TextureNode> nodes;

    public TextureAtlas();

    public void AddTexture(string name, Texture2D diffuse, Color diffuseColor, Texture2D normal, Texture2D gloss, Texture2D transtex, Texture2D shadowOffsetTex, float shininess, Vector2 scale, bool tileV, Vector2 uvTiling);
    public int GetHashCode();
    public Vector2 GetTexTiling(string name);
    public Rect GetUVRect(string name);
    public void Pack(int targetWidth, int targetHeight, int padding, bool correctPow2);

    public class TextureNode
    {
        static public bool Overlap(TextureNode a, TextureNode b);

        public Color diffuseColor;
        public Texture2D diffuseTexture;
        public Texture2D glossTexture;
        public string name;
        public Texture2D normalTexture;
        public Rect packedRect;
        public Vector2 scale;
        public Texture2D shadowOffsetTexture;
        public float shininess;
        public Rect sourceRect;
        public bool tileV;
        public Texture2D translucencyTexture;
        public Rect uvRect;
        public Vector2 uvTiling;

        public TextureNode();

        public int CompareTo(TextureNode b);

    }

}

}
