using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public int vidas = 3;

    String nome = "Mario";

    public float eixoX;
    public float eixoY;

    // Use this for initialization
    void Start () {

        //Debug.Log(vidas);
        Debug.Log("Start");

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update");
        Debug.Log(vidas);
        Debug.Log(nome);
        //transform.Translate(new Vector2(eixoX, eixoY));
    }
}
