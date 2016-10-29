using UnityEngine;
using System.Collections;

public class select : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick(){
		//here send selected servant message
		PlayerPrefs.SetString ("MyServant_id",this.transform.parent.tag);
		//Application.LoadLevel("Loading");
		DestroyObject(this.gameObject);
		DestroyObject(GameObject.Find ("left"));
		DestroyObject(GameObject.Find ("right"));
		//this.gameObject.SetActive(false);
	}
}
