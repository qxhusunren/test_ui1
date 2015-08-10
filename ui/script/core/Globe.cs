using UnityEngine;
using System.Collections;

public class Globe {
	//全局变量
	public int screenWidth;
	public int screenHeight;
	public float scale_width;
	public float scale_height;
	public float maxScale;
	public float minScale;

	public Vector3 maxScaleVec3;
	public Vector3 minScaleVec3;

	//切地图
	 public string loadName="1";
	 public System.Action afterEnterWorldHandler;
	public Globe()
	{
//		UIRoot root = GameObject.FindObjectOfType<UIRoot>();
//		if (root != null) {
//			float s = (float)root.activeHeight / Screen.height;
//			screenHeight screenHeight=  Mathf.CeilToInt(Screen.height * s);
//			screenWidth = Mathf.CeilToInt(Screen.width * s);
//			Debug.Log("height = " + screenWidth);
//			Debug.Log("width = " + screenHeight);
//		}
//
//
//		scale_width = screenWidth/680;
//		scale_height = screenHeight / 960;
//		maxScale = Mathf.Max (scale_width,scale_height);
//		minScale = Mathf.Min (scale_width,scale_height);
//		maxScaleVec3 = new Vector3 (maxScale,maxScale,0);
//		minScaleVec3= new Vector3 (minScale,minScale,0);
	}


	static private Globe _instance;
	static public Globe getInstance()
	{
		if (_instance == null) 
		{
			_instance = new Globe ();
			//_instance.init();
		}
		return _instance;
	}
}


