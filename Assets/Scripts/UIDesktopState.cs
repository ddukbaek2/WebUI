using UIKit;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// 바탕화면.
/// </summary>
public class UIDesktopState : UIModalState
{
	/// <summary>
	/// 생성됨.
	/// </summary>
	public UIDesktopState() : base()
	{
	}

	/// <summary>
	/// 해제됨.
	/// </summary>
	protected override void OnDispose(bool explicitDisposing)
	{
		base.OnDispose(explicitDisposing);
	}

	/// <summary>
	/// 로드 시작됨.
	/// </summary>
	protected override UIView OnViewLoadStart()
	{
		// 타이틀 패널 생성.
		var view = UIView.CreateUIViewFromAsset<UIDesktopPanel>();
		var verticalLayoutGroupView = view.GetView("VerticalLayoutGroup");
		var button = default(Button);

		// 시작 버튼 등록.
		var startButtonView = verticalLayoutGroupView.GetView("StartButton");
		button = startButtonView.GetComponent<Button>();
		button.onClick.AddListener(OnClickStart);

		// 옵션 버튼 등록.
		var optionButtonView = verticalLayoutGroupView.GetView("OptionButton");
		button = optionButtonView.GetComponent<Button>();
		button.onClick.AddListener(OnClickOption);

		// 종료 버튼 등록.
		var exitButtonView = verticalLayoutGroupView.GetView("ExitButton");
		button = exitButtonView.GetComponent<Button>();
		button.onClick.AddListener(OnClickExit);
		return view;
	}

	/// <summary>
	/// 시작 버튼 눌림.
	/// </summary>
	private void OnClickStart()
	{
		Debug.Log("UIDesktopState.OnClickStart()");
	}

	/// <summary>
	/// 옵션 버튼 눌림.
	/// </summary>
	private void OnClickOption()
	{
		Debug.Log("UIDesktopState.OnClickOption()");
		// Present(new UIOptionState(), true);
	}

	/// <summary>
	/// 종료 버튼 눌림.
	/// </summary>
	private void OnClickExit()
	{
		Debug.Log("UIDesktopState.OnClickExit()");
#if UNITY_EDITOR
		UnityEditor.EditorApplication.ExitPlaymode();
#else
		Application.Quit();
#endif
	}
}