using UnityEngine;
using System.Collections;

public class pvp : MonoBehaviour {
	public GameObject dialog_input;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick() {
		dialog_input.SetActive (true);
		//Application.LoadLevel ("HelloAR");
	}
}
