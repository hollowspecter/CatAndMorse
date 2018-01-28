using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeSpawner : MonoBehaviour {
	public GameObject prefab;
	void Start () {
		StartCoroutine(RandomSpawn());

		
	}
	
	void Update () {
		//spawn object in interval
		if(Input.GetButtonDown("Fire1"))
		{
			Instantiate(prefab, new Vector3(0,6,0),Quaternion.identity);
		}


	}

	IEnumerator RandomSpawn()
	{
		while(true)
		{
		float rando = Random.Range(0.2f, 1.0f);
		yield return new WaitForSeconds(rando);
		Instantiate(prefab, new Vector3(0,6,0),Quaternion.identity);
		}
	}
}
