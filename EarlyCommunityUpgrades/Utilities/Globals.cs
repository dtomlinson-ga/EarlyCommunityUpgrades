using StardewModdingAPI;

namespace EarlyCommunityUpgrades
{
	class Globals
	{
		public static IManifest Manifest { get; set; }
		public static ModConfig Config { get; set; }
		public static IModHelper Helper { get; set; }
		public static IMonitor Monitor { get; set; }

		/// <summary>
		/// A shortcut to the translation API
		/// </summary>
		/// <param name="key">The translation key</param>
		/// <param name="tokens">Tokens to replace in the translation</param>
		/// <returns>The retrieved translation</returns>
		public static string GetTranslation(string key, object tokens = null)
		{
			if (tokens == null)
			{
				return Helper.Translation.Get(key);
			}
			return Helper.Translation.Get(key, tokens);
		}
	}
}
