using UnityEngine;
using System.Collections;

public class dialog_cancel : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick(){
		GameObject dialog = GameObject.Find ("Dialog");
		dialog.SetActive (false);
	}
}
