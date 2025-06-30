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