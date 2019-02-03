using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour {
    public float speed = 10.0f;
    private Animator playerAnimator;
	// Use this for initialization
	void Start () {
        playerAnimator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxisRaw("Horizontal");
        float translationUp = Input.GetAxisRaw("Vertical");
        translation *= Time.deltaTime * speed;
        translationUp *= Time.deltaTime * speed;

        transform.Translate(translation, 0, 0);
        transform.Translate(0, translationUp, 0);

	}
}
