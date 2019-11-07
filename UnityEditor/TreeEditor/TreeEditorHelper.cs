using System;
using UnityEngine;

namespace TreeEditor
{

public class TreeEditorHelper
{
    static public string ExtractLabel(string uiString);
    static public string ExtractTooltip(string uiString);
    static public GUIContent GetGUIContent(string id);
    static public string GetOptimizedShaderName(Shader shader);
    static public bool IsTreeBarkShader(Shader shader);
    static public bool IsTreeLeafShader(Shader shader);

    public TreeEditorHelper();

    public bool AreShadersCorrect();
    public bool GUITooManyShaders();
    public bool GUIWrongShader(string uniqueID, Material value, NodeType nodeType);
    public bool NodeHasWrongMaterial(TreeEditor.TreeGroup group);
    public void OnEnable(TreeEditor.TreeData treeData);
    public void RefreshAllTreeShaders();

    public enum NodeType
    {
        BarkNode = 0,
        LeafNode = 1,
    }

}

}
