#if UNITY_EDITOR
using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace ShellLauncher.Editor
{
    public class ShellLauncher 
    {
        [MenuItem("Tools/Launch Shell")]
        public static void Launch()
        {
            switch (Application.platform)
            {
                case RuntimePlatform.WindowsEditor:
                    var projectPath = Directory.GetParent(Application.dataPath)?.FullName;
                    Process.Start("wt", "-d " + projectPath);
                    break;
                case RuntimePlatform.OSXEditor:
                    break;
                default:
                    throw new PlatformNotSupportedException();
            }
        }
        
    }
}

#endif