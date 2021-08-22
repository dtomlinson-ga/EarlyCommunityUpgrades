namespace EarlyCommunityUpgrades
{
	/// <summary>
	/// Stores config values.
	/// </summary>
	public class ModConfig
	{

		public OrderConfig Order = new OrderConfig();
		public CostsConfig Costs = new CostsConfig();
		public RequirementsConfig Requirements = new RequirementsConfig();
		public InstantUnlocksConfig InstantUnlocks = new InstantUnlocksConfig();

		public class OrderConfig
		{
			public bool shortcutsFirst = false;
		}
		public class CostsConfig
		{
			public int pamCostGold = 500000;
			public int pamCostWood = 950;
			public int shortcutCostGold = 300000;
		}

		public class RequirementsConfig
		{
			public int numFarmhouseUpgrades = 3;
			public int numRoomsCompleted = 6;
			public int numFriendshipHeartsGained = 0;
		}

		public class InstantUnlocksConfig
		{
			public bool pamsHouse = false;
			public bool shortcuts = false;
		}
	}
}