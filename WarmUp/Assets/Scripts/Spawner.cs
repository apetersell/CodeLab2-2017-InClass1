using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Sprite [] sprites;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("spriteTime", 1, 1);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spriteTime () {
		int nextNum = GetComponent<NumberGenerator> ().Next();

		makeSprite (nextNum);

	}

	void makeSprite (int num) {
		GameObject goSprite = new GameObject ();
		SpriteRenderer sr = goSprite.AddComponent<SpriteRenderer> ();
		sr.sprite = sprites[num];
		goSprite.AddComponent<Rigidbody2D> ();

		
	}
}
