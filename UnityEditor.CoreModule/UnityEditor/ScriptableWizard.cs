using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class ScriptableWizard : UnityEditor.EditorWindow
{
    static public UnityEditor.ScriptableWizard DisplayWizard(string title, Type klass);
    static public UnityEditor.ScriptableWizard DisplayWizard(string title, Type klass, string createButtonName);
    static public UnityEditor.ScriptableWizard DisplayWizard(string title, Type klass, string createButtonName, string otherButtonName);
    static public T DisplayWizard<T>(string title);
    static public T DisplayWizard<T>(string title, string createButtonName);
    static public T DisplayWizard<T>(string title, string createButtonName, string otherButtonName);

    public string createButtonName { get; set; }
    public string errorString { get; set; }
    public string helpString { get; set; }
    public bool isValid { get; set; }
    public string otherButtonName { get; set; }

    public ScriptableWizard();

    protected bool DrawWizardGUI();

}

}
