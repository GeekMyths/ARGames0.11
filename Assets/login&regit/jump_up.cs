using UnityEngine;
using System.Collections;

public class jump_up : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnClick() {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
    }
}
