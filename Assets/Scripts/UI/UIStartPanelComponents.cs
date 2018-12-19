/****************************************************************************
 * 2018.12 78S8S5TBTCBBJNU
 ****************************************************************************/

namespace QFramework.Example
{
	using UnityEngine;
	using UnityEngine.UI;

	public partial class UIStartPanel
	{
		public const string NAME = "UIStartPanel";
		[SerializeField] public Button ComfirmBtn;
		[SerializeField] public Button NorthBtn;
		[SerializeField] public Button SouthBtn;
		[SerializeField] public Button WestBtn;
		[SerializeField] public Button EastBtn;
		[SerializeField] public Button QuitBtn;

		protected override void ClearUIComponents()
		{
			ComfirmBtn = null;
			NorthBtn = null;
			SouthBtn = null;
			WestBtn = null;
			EastBtn = null;
			QuitBtn = null;
		}
	}
}
