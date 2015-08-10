using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ui1 :Baselayer{

	void Start () {

		Button bt = this.getButtonByPath ("bt1");
		bt.onClick.AddListener ( onOpenWinCLick);
		
		bt = this.getButtonByPath ("bt2");
		bt.onClick.AddListener (onChangeWordldClick);
		
		
	}

	public void onOpenWinCLick ()
	{
		InterfaceMgr._instance.openWin (InterfaceMgr.TEST);
	}

	public void onChangeWordldClick ()
	{
		WorldSetting.getInstance ().enterWorld ("2");
	}
}
