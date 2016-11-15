using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Declaring global variables
	int min;
	int max;
	int guess;
	
	// Use this for initialization
	void Start() {
		StartGame();
	}
	
	// Printing out the game description
	void StartGame() {
	
		min = 1;
		max = 1000;
		guess = 500;
		/*
		print("---------------------");
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell to me.");
		print("The lowest number you can pick is " + min + " while the highest number is " + max + ".");
		print("Is the number is higher or lower than "+ guess + "?");
		print("Up arrow = higher, down = lower, return = equal.");
		*/
		max = max + 1;
		
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();
	}
	
	// Make the next guess
	void NextGuess() {
		guess = (max + min) / 2;
		print("Higher or lower than " + guess);
		print("Up arrow = higher, down = lower, return = equal.");
	}
	
}
