using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DeathHoles : MonoBehaviour
{
    public int deathHeight = 0;
	private Rigidbody rb;
	public GameObject deathSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		deathSound = GameObject.FindWithTag("sounds");
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.y < 0) {
			Destroy(deathSound);
			levelTracker.levelNumber = 0;
			SceneManager.LoadScene("GameOver");
		}
    }
}
