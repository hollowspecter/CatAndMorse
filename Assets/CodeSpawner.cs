using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeSpawner : MonoBehaviour {
	public GameObject prefab;
	void Start () {
		StartCoroutine(RandomSpawn());

		
	}

	IEnumerator RandomSpawn()
	{
		while(true)
		{
		float rando = Random.Range(0.2f, 1.0f);
		yield return new WaitForSeconds(rando);
		Instantiate(prefab, transform.position, Quaternion.identity);
		}
	}
}
