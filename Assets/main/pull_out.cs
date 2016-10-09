using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pull_out : MonoBehaviour {
	private bool isRight;
	private bool click;
	private Resolution[] res;
	private GameObject game;
	private float distance;
	private Vector3 endPoi;
	private float process;
	// Use this for initialization
	void Start () {
		isRight = false;
		click = false;
		res = Screen.resolutions;
		game = GameObject.Find ("friend");
		distance = res [0].width / 32;
	}
	
	// Update is called once per frame
	void Update()
	{
		
		if(click){
			process += Time.deltaTime * 2;
			if (process < 1) {
				GameObject.Find ("friend").transform.position = Vector3.Lerp (game.transform.position, endPoi, process);
			} else {
				click = false;
			}
		}

	}

	public void Onclick () {
		process = 0;
		click = true;
		isRight = !isRight;
		if (isRight) {
			endPoi = new Vector3 (game.transform.position.x + distance, game.transform.position.y, game.transform.position.z);
		} else {
			endPoi = new Vector3 (game.transform.position.x - distance, game.transform.position.y, game.transform.position.z);
		}
	}
}
