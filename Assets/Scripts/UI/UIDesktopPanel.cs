using UIKit;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// 타이틀 패널.
/// </summary>
[AssetPath("UI/UIDesktopPanel")]
public class UIDesktopPanel : UIPanel
{
	#region INSPECTOR
	[SerializeField] private Button m_StartButton;
	//[SerializeField] private Button m_InventoryButton;
	[SerializeField] private Button m_OptionButton;
	[SerializeField] private Button m_ExitButton;
	#endregion
}