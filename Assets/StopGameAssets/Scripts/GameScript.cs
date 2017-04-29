using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {

	public GameObject bomb;
	public GameObject explosion;
	public GameObject canvas1;
	public GameObject canvas2;
	public GameObject flame;
	public GameObject hanabi1;
	public GameObject hanabi2;
	public GameObject hanabi3;

	public Text timeLabel;
	float timer = 0.0f;
	float time = 15.0f;

	float waittimer = 0.0f;

	bool wait = false;

	int flag = 1;

	//public AudioClip soundHeart;
	//AudioSource audioSource1;

	public AudioClip soundBad;
	AudioSource audioSource2;

	//public AudioClip soundClock;
	//AudioSource audioSource3;


	// Use this for initialization
	void Start () {
		//audioSource1 = gameObject.AddComponent<AudioSource> ();
		//audioSource1.clip = soundHeart;

		audioSource2 = gameObject.AddComponent<AudioSource> ();
		audioSource2.clip = soundBad;

		//audioSource3 = gameObject.AddComponent<AudioSource> ();
		//audioSource3.clip = soundClock;

		bomb.SetActive (true);
		explosion.SetActive (false);
		flame.SetActive (false);
		hanabi1.SetActive (false);
		hanabi2.SetActive (false);
		hanabi3.SetActive (false);
		canvas2.SetActive (false);

		//audioSource3.Play ();

	}
	
	// Update is called once per frame
	void Update () {

		if (wait == true) {
			waittimer += Time.deltaTime;
			if (waittimer >= 1.5f) {
				Gotohell ();
			}
		}

				

		if (flag == 1) {
			if(timer <= 15.0f){
			timer += Time.deltaTime;
			time = 15.0f - timer;
			timeLabel.text = time.ToString ("f1");
			//transform.localScale = new Vector3(1, 1, 1)*timer
				if (timer >= 10.0f) {
					//audioSource1.Play ();
				}
			}
		}
	}

	/*
	public void StartButton(){
		flag = 1;
		timer = 0.0f;
	}
	*/

	public void StopButton(){
		//Debug.Log ("StopButton来てるよ");
		//audioSource3.Stop ();
		flag = 0;
		if (14.5f <= timer && timer <= 15.0f) {
			//transform.localScale *= 2;
			hanabi1.SetActive (true);
			hanabi2.SetActive (true);
			hanabi3.SetActive (true);
			explosion.SetActive (true);
			bomb.SetActive (false);
			audioSource2.Play ();
			canvas1.SetActive (false);
			canvas2.SetActive (true);



		}else{
			wait = true;
			audioSource2.Play ();
			explosion.SetActive (true);
			flame.SetActive (true);
		}
		timer = 0.0f;
		time = 15.0f;
	}

	void Gotohell(){
		SceneManager.LoadScene ("GameOver");
	}
				
}
