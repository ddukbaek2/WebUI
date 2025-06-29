using UIKit;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// 바탕화면 패널.
/// </summary>
[AssetPath("UI/UIDesktopPanel")]
public class UIDesktopPanel : UIPanel
{
	#region INSPECTOR
	[SerializeField] private Button m_StartButton;
	[SerializeField] private Button m_InventoryButton;
	[SerializeField] private Button m_OptionButton;
	[SerializeField] private Button m_ExitButton;
	#endregion

	/// <summary>
	/// 초기화됨.
	/// </summary>
	protected override void Start()
	{
		base.Start();
		
		// 작업표시줄 추가.
		// 바탕화면 아이콘 처리.
	}
}