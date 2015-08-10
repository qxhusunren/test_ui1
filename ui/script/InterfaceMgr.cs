using UnityEngine;
using System.Collections;
using System.Collections.Generic ;

public class InterfaceMgr  : MonoBehaviour {
	static public string TEST ="wintest";
	static public InterfaceMgr  _instance;
	public GameObject winLayerObj;
	private Transform winLayer;

	Dictionary<string,winData> winPool =new Dictionary<string,winData>();

	void Start () {
		_instance = this.GetComponent<InterfaceMgr> ();
		creatWinData (TEST);

		winLayer = winLayerObj.transform;
	}

	winData creatWinData(string name)
	{
		winData windata = new winData ();
		windata.winName = name;
		winPool.Add (name,windata);
		return windata;
	}
	
	public void openWin(string name)
	{
		winData windata = winPool [name];

		if (windata.winName == null)
			return;

		if (windata.winItem == null) {
			GameObject commonUIPrefab = Resources.Load (windata.winName) as GameObject; 
			GameObject root = Instantiate (commonUIPrefab) as GameObject;  
	
			root.transform.SetParent (winLayer);
			windata.winItem = root;
			winPool.Remove(name);
			winPool.Add (name,windata);
		} 
		else 
		{
			windata.winItem.SetActive(true);
		}
	}

	public void closeWin(string name)
	{
		winData windata = winPool [name];
		if (windata.winItem == null)
			return;
		windata.winItem.SetActive(false);
	}
}


public struct winData
{
	public string winName;
	public GameObject winItem;
}