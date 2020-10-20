using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Global variables
    public int max;
    public int min;
    public int guess;

    void Start() {
        StartGame();
    }

    void Update() {
        InputHandler();
    }

    void StartGame () {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Tjenixen och välkommen till Number Wizard");
        Debug.Log("Pick a number between...");
        Debug.Log("Highest possible number: " + max);
        Debug.Log("Lowest possible number: " + min);
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Press Up for Higher, Press Down for Lower, or Enter for Correct");
        max += 1;
    }

    void InputHandler () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) {
            StartGame();
        }
    }

    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Is " + guess + " your number?");
    }

}