using ICities;
using UnityEngine;

namespace UKDistrictNames {

	public class Mod : IUserMod {

		public string Name {
			get { return "UK District Names"; }
		}

		public string Description {
			get { return "Replaces generic district names with British-flavoured ones."; }
		}
	}
}