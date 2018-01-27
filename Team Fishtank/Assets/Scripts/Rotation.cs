﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	[SerializeField]
	public float multiplier;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.up * Time.deltaTime *multiplier, Space.World);


	}
}
