using StardewModdingAPI;

namespace EarlyCommunityUpgrades
{
	/// <summary>The mod entry point.</summary>
	public class ModEntry : Mod
	{
		private AssetEditor modAssetEditor;

		/// <summary>The mod entry point.</summary>
		/// <param name="helper" />
		public override void Entry(IModHelper helper)
		{
			Globals.Config = helper.ReadConfig<ModConfig>();
			Globals.Helper = helper;
			Globals.Monitor = Monitor;
			Globals.Manifest = ModManifest;

			modAssetEditor = new AssetEditor();
			helper.Content.AssetEditors.Add(modAssetEditor);

			helper.Events.GameLoop.GameLaunched += (sender, args) => ModConfigMenuHelper.TryLoadModConfigMenu();
			helper.Events.GameLoop.ReturnedToTitle += (sender, args) => modAssetEditor.ReloadI18n();
			helper.Events.Player.Warped += (sender, args) => CommunityUpgradesPatches.CheckInstantUnlocks();

			if (CommunityUpgradesPatches.ApplyHarmonyPatches())
				Monitor.Log("Patches successfully applied");
		}
	}
}
