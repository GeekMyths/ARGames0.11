using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pull_out : MonoBehaviour {
	private bool isRight;
	private bool click;
	private Rigidbody game;
	private float distance;
	private Vector3 endPoi;
	private float process;
	private RectTransform group_friend;
	// Use this for initialization
	void Start () {
		isRight = false;
		click = false;
		game = GameObject.Find ("friend").GetComponent<Rigidbody>();
		group_friend = GameObject.Find ("friend").GetComponent<RectTransform>();
		distance = group_friend.rect.width / 20;
		endPoi = new Vector3 (game.transform.position.x - distance, game.transform.position.y, game.transform.position.z);
		game.position = endPoi;
	}
	
	// Update is called once per frame
	void Update()
	{
		if(click){
			process += 0.02f * 2;
			if (process < 1) {
				game.MovePosition(Vector3.Lerp (game.transform.position, endPoi, process));
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
