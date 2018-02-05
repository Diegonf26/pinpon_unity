using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public Animator anim;
    public Rigidbody rbody;
    private float inputH;
    private float inputV;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a"))
        {
            //print("Presione a");
            anim.Play("mov_cabeza", -1,0f);
        }
        if (Input.GetKeyDown("s")) anim.Play("caminar", -1, 0f);
        if (Input.GetKeyDown("d")) anim.Play("mov_cabeza_001", -1, 0f);
        if (Input.GetKeyDown("x")) anim.Play("salto", -1, 0f);
        if (Input.GetMouseButtonDown(0)) anim.Play("salto", -1, 0f);

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);

        float moveX = inputH * 5000f * Time.deltaTime;
        float moveZ = inputV * 5000f * Time.deltaTime;

        rbody.velocity = new Vector3(moveX, 0f, moveZ);

    }
}
