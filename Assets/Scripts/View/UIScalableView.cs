using UIKit;
using UnityEngine;


/// <summary>
/// 크기를 변경 할 수 있는 뷰.
/// </summary>
public class UIScalableView : UIView
{
	#region INSPECTOR
	[SerializeField] private UIView m_View;
	[SerializeField] private UIDraggableFrame m_DraggableFrame;
	#endregion
	
	/// <summary>
	/// 드래그 중인지 여부.
	/// </summary>
	private bool m_IsDragging;

	/// <summary>
	/// 생성됨.
	/// </summary>
	protected override void Awake()
	{
		base.Awake();

		// m_View = CreateUIView<UIView>();
		// m_View.RectTransform.SetParent(RectTransform);
		m_DraggableFrame = AssetLoader.InstantiateWithComponentFromAssetPath<UIDraggableFrame>();
		m_DraggableFrame.RectTransform.SetParent(RectTransform);
	}

	/// <summary>
	/// 파괴됨.
	/// </summary>
	protected override void OnDestroy()
	{
		GameObject.Destroy(m_DraggableFrame.gameObject);
		GameObject.Destroy(m_View.gameObject);

		base.OnDestroy();
	}

	/// <summary>
	/// 위치 변경됨.
	/// </summary>
	protected virtual void OnPosition(Vector3 position)
	{
	}

	/// <summary>
	/// 크기 변경됨.
	/// </summary>
	protected virtual void OnSize(Vector2 size)
	{
	}

	/// <summary>
	/// 회전 변경됨.
	/// </summary>
	protected virtual void OnRotation(Quaternion rotation)
	{
	}
}