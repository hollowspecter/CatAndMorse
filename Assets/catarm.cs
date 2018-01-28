using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catarm : MonoBehaviour {

    public Sprite[] sprites;
    private SpriteRenderer render;

    void Awake()
    {
        render = GetComponent<SpriteRenderer>();
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            render.sprite = sprites[1];
            sfx.instance.playshortbeep();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            render.sprite = sprites[0];
        }
    }
}
