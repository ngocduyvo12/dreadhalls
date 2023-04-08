using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelTracker : MonoBehaviour
{
    private Text text;
	public static int levelNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
		levelNumber++;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Level: " + levelNumber;
    }
}
