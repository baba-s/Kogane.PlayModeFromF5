using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class PlayModeFromF5
    {
        [Shortcut( "Kogane/Play", KeyCode.F5 )]
        private static void Run()
        {
            EditorApplication.isPlaying = !EditorApplication.isPlaying;
        }

        [Shortcut( "Kogane/Stop", KeyCode.F5, ShortcutModifiers.Shift )]
        private static void Stop()
        {
            EditorApplication.isPlaying = false;
        }
    }
}