/****************************************************************************
 * 2018.12 78S8S5TBTCBBJNU
 ****************************************************************************/

namespace QFramework.Example
{
	using UnityEngine;
	using UnityEngine.UI;

	public partial class UIMediaInfoPanel
	{
		public const string NAME = "UIMediaInfoPanel";
		[SerializeField] public Button BackBtn;
		[SerializeField] public Text MediaTypeValue;
		[SerializeField] public Text MediaNumberValue;
		[SerializeField] public Text AssetsNumberValue;
		[SerializeField] public Text MediaFormatValue;
		[SerializeField] public Text MediaLocationValue;
		[SerializeField] public Text OperationEntitiesValue;
		[SerializeField] public Text AgentCompanyValue;
		[SerializeField] public Text PublishContentValue;
		[SerializeField] public Text StartTimeValue;
		[SerializeField] public Text EndTimeValue;
		[SerializeField] public Button DetailBtn;
		[SerializeField] public Image ADBackground;
		[SerializeField] public Image ADImage;
		[SerializeField] public Button CloseDetailbtn;

		protected override void ClearUIComponents()
		{
			BackBtn = null;
			MediaTypeValue = null;
			MediaNumberValue = null;
			AssetsNumberValue = null;
			MediaFormatValue = null;
			MediaLocationValue = null;
			OperationEntitiesValue = null;
			AgentCompanyValue = null;
			PublishContentValue = null;
			StartTimeValue = null;
			EndTimeValue = null;
			DetailBtn = null;
			ADBackground = null;
			ADImage = null;
			CloseDetailbtn = null;
		}
	}
}
