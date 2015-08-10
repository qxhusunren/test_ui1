using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Baselayer : MonoBehaviour {
	public	Transform getTransformByPath(string path)
	{
		string[] arr = path.Split (new char[]{'.'}); 
		Transform trans=this.transform;
		for (int i =0; i<arr.Length; i++) {
			trans = trans.Find(arr[i]);
		}
		return trans;
	}

	public	Button getButtonByPath(string path)
	{
		string[] arr = path.Split (new char[]{'.'}); 
		Transform trans=this.transform;
		for (int i =0; i<arr.Length; i++) {
			trans = trans.Find(arr[i]);
		}
		return trans.GetComponent<Button>();
	}
}
