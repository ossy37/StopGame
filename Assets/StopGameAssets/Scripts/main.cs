using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

	bool down;
	float timer = 0.0f;

	public GameObject canvas0;
	public GameObject canvas1;

	public AudioClip soundStart;
	AudioSource audioSource1;

	//public AudioClip soundBgm;
	//AudioSource audioSource2;

	// Use this for initialization
	void Start () {
		audioSource1 = gameObject.AddComponent<AudioSource> ();
		audioSource1.clip = soundStart;

		//audioSource2 = gameObject.AddComponent<AudioSource> ();
		//audioSource2.clip = soundBgm;

		canvas0.SetActive (true);
		canvas1.SetActive (false);

		//audioSource2.Play ();

		down = false;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1)){
			//audioSource2.Stop ();
			audioSource1.Play ();//スタート音
			down = true;
			canvas0.SetActive (false);
		}

		if(down == true){
			timer += Time.deltaTime;
			if(timer >= 0.7f){
				Change ();
				down = false;
			}
		}
	}

	void Change (){
		canvas1.SetActive (true);
	}
}
