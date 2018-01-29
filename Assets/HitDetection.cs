using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

    public BeautifulText text;
	public GameObject ps;

	int failCounter = 0;
    int goodcounter = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
		{	
			if(Physics.Raycast(transform.position, transform.right,20.0f))
			{
                goodcounter++;
				Instantiate(ps, new Vector3(0.01f,-1.05f,-2.0f), Quaternion.identity);
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
            text.BadWord();
		}
		if (goodcounter > 4)
        {
            goodcounter = 0;
            text.GoodWord();
        }
	}
}
