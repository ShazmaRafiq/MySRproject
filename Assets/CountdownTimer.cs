using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    public Text countdownText;
    private bool isGameStarted = false;
    private bool gameEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0.0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        if(isGameStarted)
        {
            Debug.Log("Game Started");
        }
        else if (currentTime <= 0)
        {
            Debug.Log("Game Ended");

        }
    }
}
