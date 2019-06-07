using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject Target;
	public GameObject WinText;
	public Text ScoreText;
	public int score=0;
	bool win=false;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 1f, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (win == true) {
			CancelInvoke ("Spawn");
		}
	
	}

	void Spawn(){
		float randomX = Random.Range (-5.9f, 5.9f);
		float randomY = Random.Range (4.4f, -4.4f);
		Vector3 RandomPos = new Vector3 (randomX, randomY, 0);
		Instantiate (Target, RandomPos, Quaternion.identity);
	}

	public void IncrementScore(){
		score++;
		ScoreText.text = score.ToString ();
		if (score >= 10) {
			win = true;
			WinText.SetActive (true);
		}


	}
}
