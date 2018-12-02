using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int minInt;
    int maxInt;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}

    void StartGame ()
    {
        minInt = 1;
        maxInt = 1000;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please pick a number");
        Debug.Log("The maximum number you can pick is: " + (maxInt - 1));
        Debug.Log("The minimum number you can pick is: " + minInt);
        Debug.Log("press Up if Higher; Down if Lower; Enter if Correct");
        
        PrintGuess();
        maxInt = maxInt + 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            minInt = guess;
            PrintGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            maxInt = guess;
            PrintGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I win!");
            StartGame();
        }
	}

    void PrintGuess ()
    {
        guess = (maxInt + minInt ) / 2;
        Debug.Log("Is your number " + guess);
    }
}
