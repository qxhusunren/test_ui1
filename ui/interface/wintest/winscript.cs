using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class winscript :Baselayer {

	// Use this for initialization
	void Start () {
		Transform bt = this.getTransformByPath ("pannel.Button");
		Button btt = bt.GetComponent<Button> ();
		btt.onClick.AddListener (onClose);
	}

	void onClose()
	{
		InterfaceMgr._instance.closeWin (InterfaceMgr.TEST);
	}

}
