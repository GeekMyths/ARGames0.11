using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pull_out : MonoBehaviour {
	public float speed;
	private bool isRight;
	private bool click;
	public float time;
	private float step;
	private Resolution[] res;
	private GameObject game;
	// Use this for initialization
	void Start () {
		isRight = false;
		click = false;
		res = Screen.resolutions;
		game = GameObject.Find ("friend");
	}
	
	// Update is called once per frame
	void Update()
	{
		
		if(click){
			if(isRight){
				GameObject.Find("friend").transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition,new Vector3(-215.7f, -32.8f, 0.0f),step);
			} else {
				//gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition,new Vector3(-215.7f, -32.8f, 0.0f),step);
			}
		}
		print (game.GetComponent<RectTransform>().rect.width +"+"+game.GetComponent<RectTransform>().rect.width);
		print (res [0].width + "+" + res [0].height);

	}

	public void Onclick () {
		step = Time.deltaTime * speed;
		click = true;
		isRight = !isRight;
	}

}
