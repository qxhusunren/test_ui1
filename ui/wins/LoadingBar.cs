using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LoadingBar : MonoBehaviour {
	Image loadingMc;
	Text text;
	AsyncOperation async;
	float per;
	void Start()
	{
		loadingMc=this.transform.FindChild ("Image").GetComponent<Image> ();
		text = this.transform.FindChild ("Text").GetComponent<Text> ();
		text.text = "0%";
		loadingMc.fillAmount = 0;
		per = 0f;
		StartCoroutine(loadScene());
	}
	

	IEnumerator loadScene()
	{
		async = Application.LoadLevelAsync (Globe.getInstance().loadName);
		async.allowSceneActivation = false;
		while(async.progress<0.9f) 
		{
			per+=0.01f;
			text.text =Mathf.Floor( per*100)+"%";
			loadingMc.fillAmount = per;
			yield return new WaitForEndOfFrame();
		}

		while (per <1f) 
		{
			per+=0.01f;
			text.text =Mathf.Floor( per*100)+"%";
			loadingMc.fillAmount = per;
			yield return new WaitForEndOfFrame();
		}

		if(Globe.getInstance().afterEnterWorldHandler!=null)
		{
			Globe.getInstance().afterEnterWorldHandler();
			Globe.getInstance().afterEnterWorldHandler=null;
		}
		async.allowSceneActivation = true;

	} 
}

