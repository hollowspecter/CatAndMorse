using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeautifulText : MonoBehaviour {

    private Text text;
    public GameObject spawner;

    private string originaltext;
    private string[] words;
    private int counter = 0;

    private string[] badwords = new string[] { "fuck", "shit", "dickface", "asshole", "shitbag", "cocknose", "bitch", "bollocks", "thundercunt", "dickweasel", "fucknugget", "cunt", "fuckface", "shitmagnet" };

    void Awake()
    {
        text = GetComponent<Text>();
        originaltext = text.text;
        words = originaltext.Split(' ');
        text.text = "";
    }

    public void GoodWord()
    {
        text.text += words[counter] + " ";
        counter++;
    }

    public void BadWord()
    {
        sfx.instance.playmeow();
        int index = Random.Range(0, badwords.Length);
        text.text += badwords[index] + " ";
        counter++;
    }
    private bool done = false;
    void Update()
    {
        if (counter == words.Length && !done)
        {
            sfx.instance.playende();
            Destroy(spawner);
            done = true;
        }

    }
}
