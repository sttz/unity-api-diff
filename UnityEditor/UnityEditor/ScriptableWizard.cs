using System;
using UnityEngine;

namespace UnityEditor
{

public class ScriptableWizard : UnityEditor.EditorWindow
{
    static public T DisplayWizard(string title);
    static public T DisplayWizard(string title, string createButtonName);
    static public T DisplayWizard(string title, string createButtonName, string otherButtonName);
    static public UnityEditor.ScriptableWizard DisplayWizard(string title, Type klass, string createButtonName);
    static public UnityEditor.ScriptableWizard DisplayWizard(string title, Type klass);
    static public UnityEditor.ScriptableWizard DisplayWizard(string title, Type klass, string createButtonName, string otherButtonName);

    public string createButtonName { get; set; }
    public string errorString { get; set; }
    public string helpString { get; set; }
    public bool isValid { get; set; }
    public string otherButtonName { get; set; }

    public ScriptableWizard();

    protected bool DrawWizardGUI();

}

}
