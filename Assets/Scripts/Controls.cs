﻿using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public GameObject go;

	void Start()
	{
		go.SetActive (false);
	}
	void Update()
	{
		transform.renderer.enabled = JouerSimple.anglais;
		transform.collider.enabled = JouerSimple.anglais;
	}
	
	void OnMouseEnter()
	{
		transform.localScale *= 1.1f;
	}
	
	void OnMouseExit()
	{
		transform.localScale *= 0.909090f;
	}

	void OnMouseUp()
	{
		go.SetActive (!go.GetActive ());
	}
}
