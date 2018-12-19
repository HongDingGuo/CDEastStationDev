/****************************************************************************
 * 2018.12 78S8S5TBTCBBJNU
 ****************************************************************************/

namespace QFramework.Example
{
	using UnityEngine;
	using UnityEngine.UI;

	public partial class UIGameMainPanel
	{
		public const string NAME = "UIGameMainPanel";
		[SerializeField] public Button MediaBtn;
		[SerializeField] public Button ZichanBtn;
		[SerializeField] public Button ExitBtn;
		[SerializeField] public Button WaitingFloorBtn;
		[SerializeField] public Button GoFloorBtn;
		[SerializeField] public Button SubwayFloorBtn;
		[SerializeField] public ScrollRect MediaSelectScrollView;
		[SerializeField] public Button MediaSelectItem;
		[SerializeField] public RectTransform MediaSelectContent;
		[SerializeField] public ScrollRect MediaLowerSelect;
		[SerializeField] public Button MediaLowerItem;
		[SerializeField] public RectTransform MediaLowerSelectContent;
		[SerializeField] public ScrollRect ZichanSelectScrollView;
		[SerializeField] public RectTransform ZichanSelectContent;
		[SerializeField] public ScrollRect HouchecengSelect;
		[SerializeField] public Button hcdgcBtn;
		[SerializeField] public Button hczjBtn;
		[SerializeField] public Button hcxgcBtn;
		[SerializeField] public ScrollRect ChufacengSelect;
		[SerializeField] public Button A2Btn;
		[SerializeField] public Button A13Btn;
		[SerializeField] public Button A26Btn;
		[SerializeField] public ScrollRect DitiecengSelect;
		[SerializeField] public Button dtdgcBtn;
		[SerializeField] public Button dtzjBtn;
		[SerializeField] public Button dtxgcBtn;
		[SerializeField] public InputField SeachInputField;
		[SerializeField] public Button ClickSeachBtn;
		[SerializeField] public Image MediaDesc;
		[SerializeField] public Text MediaDescText;

		protected override void ClearUIComponents()
		{
			MediaBtn = null;
			ZichanBtn = null;
			ExitBtn = null;
			WaitingFloorBtn = null;
			GoFloorBtn = null;
			SubwayFloorBtn = null;
			MediaSelectScrollView = null;
			MediaSelectItem = null;
			MediaSelectContent = null;
			MediaLowerSelect = null;
			MediaLowerItem = null;
			MediaLowerSelectContent = null;
			ZichanSelectScrollView = null;
			ZichanSelectContent = null;
			HouchecengSelect = null;
			hcdgcBtn = null;
			hczjBtn = null;
			hcxgcBtn = null;
			ChufacengSelect = null;
			A2Btn = null;
			A13Btn = null;
			A26Btn = null;
			DitiecengSelect = null;
			dtdgcBtn = null;
			dtzjBtn = null;
			dtxgcBtn = null;
			SeachInputField = null;
			ClickSeachBtn = null;
			MediaDesc = null;
			MediaDescText = null;
		}
	}
}
