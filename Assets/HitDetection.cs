﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

	int failCounter = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
		{	
			if(Physics.Raycast(transform.position, transform.right,20.0f))
			{
				//vivi buschtsabe
				Debug.Log("hit");

			}

			else
			{
				failCounter++;
			}

		}

		if(failCounter >4 )
		{
			//vivis schipfwortt
			failCounter = 0;
			Debug.Log("fuck");
		}
		
	}
}
