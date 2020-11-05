using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;
    int SpacePressed = 0;

    // Start is called before the first frame update
    void Start()
    {
        //scoreText.GetComponent<Text>().text = "Start Function";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpacePressed++;
            print(SpacePressed);
            scoreText.GetComponent<Text>().text = "Spacebar: " + SpacePressed;
        }
    }
}
