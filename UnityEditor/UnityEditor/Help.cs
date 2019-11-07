using System;
using UnityEngine;

namespace UnityEditor
{

public class Help
{
    static public void BrowseURL(string url);
    static public string GetHelpURLForObject(Object obj);
    static public bool HasHelpForObject(Object obj);
    static public void ShowHelpForObject(Object obj);
    static public void ShowHelpPage(string page);

    public Help();

}

}
