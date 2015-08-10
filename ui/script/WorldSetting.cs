using UnityEngine;
using System.Collections;


public class WorldSetting {

	public void enterWorld(string worldName)
	{
		loadScene(beforeLoad,worldName,afterLoad);

	}

	void beforeLoad()
	{
		Debug.Log("begin!!!!!!!!");
	}

	void afterLoad()
	{
		Debug.Log("end!!!!!!!!");
	}

	public void loadScene(System.Action before, string sceneName, System.Action after) 
	{   
		if(before!=null)
		before();
		if(Application.loadedLevelName != sceneName) 
		{           
			Globe.getInstance().loadName = sceneName;
			Globe.getInstance().afterEnterWorldHandler =after;
			Application.LoadLevel("loading");
		}else 
		{ 
			if(after!=null)
			after();
		}
	}



	static private WorldSetting _instance;
	static public WorldSetting getInstance()
	{
		if (_instance == null)
			_instance = new WorldSetting ();
		return _instance;
	}
}
