using UnityEngine;
using UnityEngine.UI;


namespace UIKit
{
	/// <summary>
	/// 잡고 움직일 수 있는 프레임.
	/// </summary>
	[AssetPath("UI/UIDraggableFrame")]
	public class UIDraggableFrame : UIBase
	{
		#region INSPECTOR
		[SerializeField] private Image m_Top;
		[SerializeField] private Image m_Bottom;
		[SerializeField] private Image m_Left;
		[SerializeField] private Image m_Right;
		[SerializeField] private Image m_LeftTop;
		[SerializeField] private Image m_RightTop;
		[SerializeField] private Image m_LeftBottom;
		[SerializeField] private Image m_RightBottom;
		#endregion

		/// <summary>
		/// 생성됨.
		/// </summary>
		protected override void Awake()
		{
			base.Awake();
		}

		/// <summary>
		/// 초기화됨.
		/// </summary>
		protected override void Start()
		{
			base.Start();
			ResizeFrame(30f);
		}
		
		/// <summary>
		/// 프레임 사이즈 변경.
		/// </summary>
		public void ResizeFrame(float size)
		{
			var sizeDelta = m_Top.rectTransform.sizeDelta;
			sizeDelta.x = -(size * 2);
			sizeDelta.y = size;
			m_Top.rectTransform.sizeDelta = sizeDelta;

			sizeDelta = m_Bottom.rectTransform.sizeDelta;
			sizeDelta.x = -(size * 2);
			sizeDelta.y = size;
			m_Bottom.rectTransform.sizeDelta = sizeDelta;
			
			sizeDelta = m_Left.rectTransform.sizeDelta;
			sizeDelta.x = size;
			sizeDelta.y = -(size * 2);
			m_Left.rectTransform.sizeDelta = sizeDelta;
			
			sizeDelta = m_Right.rectTransform.sizeDelta;
			sizeDelta.x = size;
			sizeDelta.y = -(size * 2);
			m_Right.rectTransform.sizeDelta = sizeDelta;

			sizeDelta = m_LeftTop.rectTransform.sizeDelta = sizeDelta;
			sizeDelta.x = sizeDelta.y = size;
			m_LeftTop.rectTransform.sizeDelta = sizeDelta;
			
			sizeDelta = m_RightTop.rectTransform.sizeDelta = sizeDelta;
			sizeDelta.x = sizeDelta.y = size;
			m_RightTop.rectTransform.sizeDelta = sizeDelta;
			
			sizeDelta = m_LeftBottom.rectTransform.sizeDelta = sizeDelta;
			sizeDelta.x = sizeDelta.y = size;
			m_LeftBottom.rectTransform.sizeDelta = sizeDelta;
			
			sizeDelta = m_RightBottom.rectTransform.sizeDelta = sizeDelta;
			sizeDelta.x = sizeDelta.y = size;
			m_RightBottom.rectTransform.sizeDelta = sizeDelta;
		}
	}	
}