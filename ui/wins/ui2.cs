using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ui2 :Baselayer {

	void Start () {
		
		Button bt = this.getButtonByPath ("bt");
		bt.onClick.AddListener ( onChangeWordldClick);

	}

	public void onChangeWordldClick ()
	{
		WorldSetting.getInstance ().enterWorld ("1");
	}
}
