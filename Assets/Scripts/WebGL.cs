using System.Runtime.InteropServices;
using UnityEngine;


/// <summary>
/// WebGL 플러그인.
/// </summary>
public static class WebGL
{
#if UNITY_WEBGL
	[DllImport("__Internal")]
	private static extern void HelloWorld();

	[DllImport("__Internal")]
	private static extern int AddNumbers(int a, int b);
#endif

	/// <summary>
	/// 생성됨.
	/// </summary>
	static WebGL()
	{
	}
}