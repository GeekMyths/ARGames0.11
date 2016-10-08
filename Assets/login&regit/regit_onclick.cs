using UnityEngine;
using System.Collections;

public class regit_onclick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void OnClick() {
        StartCoroutine(WaitAndPrint(0.25F));
        
    }
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel("Gegit");
    }
}
