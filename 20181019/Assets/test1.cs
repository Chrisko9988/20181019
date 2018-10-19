using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        check = true;
	}
	// Update is called once per frame
	void Update () {
		
	}

    public Image img1;
    public RawImage img2;
    public Texture t1;
    public Sprite s1;
    bool check;
    public Text mytext;
    int count = 0;


    public void ButtonOnClick() {
        count++;
        mytext.text = "Count:" + count.ToString();
    }

    public void ToggleCheck() {
        check = !check;
        if (check)
        {
            img1.sprite = s1;
            img2.texture = t1;
        }
        else {
            img1.sprite = null;
            img2.texture = null;
        }
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene(0);
    }
}
