using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour 
{

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        //Debug.Log() serve para escrever textos no console
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max++; //Se não for 1001 o máximo, os palpites do programa nunca vão chegar ao número 1000
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Caso o usuário diga que o numero dele é maior que o nosso palpite            
            min = guess; //Atualizamos o mínimo para compactar o nosso intervalo de palpites
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Caso o usuário diga que o numero dele é menor que o nosso palpite            
            max = guess; //Atualizamos o máximo para compactar o nosso intervalo de palpites
            NextGuess();           
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
