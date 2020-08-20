using UnityEditor;

namespace Kogane.Internal
{
	internal static class PlayModeFromF5
	{
		private const string ITEM_NAME_RUN  = "Edit/UniPlayModeFromF5/Run _F5";
		private const string ITEM_NAME_STOP = "Edit/UniPlayModeFromF5/Stop #_F5";

		[MenuItem( ITEM_NAME_RUN )]
		private static void Run()
		{
			EditorApplication.isPlaying = true;
		}

		[MenuItem( ITEM_NAME_RUN, true )]
		private static bool CanRun()
		{
			return !EditorApplication.isPlaying;
		}

		[MenuItem( ITEM_NAME_STOP )]
		private static void Stop()
		{
			EditorApplication.isPlaying = false;
		}

		[MenuItem( ITEM_NAME_STOP, true )]
		private static bool CanStop()
		{
			return EditorApplication.isPlaying;
		}
	}
}