using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{

    public static GameLogic Instance { get; set; }
    public float timeLeft = 10;
    public int gameCount = 1;
    public int player1Score = 0;
    public int player2Score = 0;
    private int _timerValue = 0;
    public Player1 player1;
    public Player2 player2;
    public TextMeshProUGUI player1Canvas;
    public TextMeshProUGUI player2Canvas;
    public TextMeshProUGUI timerCanvas;
    
    // initialize player 1 as the chaser
    enum Role 
    {
        Chaser,
        Runner,
    }
    Role player1role = Role.Chaser;
    Role player2role = Role.Runner;

    // awake() is called at the start after the game object has been instantiated

    void updateCanvas(){
        player1Canvas.text = "Player1: "+player1Score; 
        player2Canvas.text = "Player2: "+player2Score;
        timerCanvas.text = ""+_timerValue;
    }
    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;

        //set player1 (catcher) speed to 20, player2 (runner) speed to 10
        player1.thrust = 20;
        player2.thrust = 15;

        //print debug statements
        Debug.Log("Round" + gameCount);
        Debug.Log("Player1" + (player1role == Role.Chaser ? "Chaser" : "Runner"));
        Debug.Log("Player2" + (player2role == Role.Chaser ? "Chaser" : "Runner"));
        Debug.Log("Player1Score" + player1Score);
        Debug.Log("Player2Score" + player2Score);
	}

    // switch() is called whenever timer expires or collision happens
    void Switch()
    {

        //change time back to 10
        timeLeft = 10;

        //increment gameCount
        gameCount++;

        //game finishes after 10 rounds
        if (gameCount > 10) {
            Debug.Log("Game Over");
            return;
        }

        //update score swap chaser and runner
        Role temp = player1role;
        player1role = player2role;
        player2role = temp;

        //update the location
        player1.goBackOrigin();
        player2.goBackOrigin();

        //update the thrust: if catcher 20, if runner 10
        player1.thrust = (player1role == Role.Chaser ? 20 : 15);
        player2.thrust = (player2role == Role.Chaser ? 20 : 15);

        //print debug statements
        Debug.Log("Round" + gameCount);
        Debug.Log("Player1" + (player1role == Role.Chaser ? "Chaser" : "Runner"));
        Debug.Log("Player2" + (player2role == Role.Chaser ? "Chaser" : "Runner"));
        Debug.Log("Player1Score" + player1Score);
        Debug.Log("Player2Score" + player2Score);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
            // time's used up, increment score for runner, and call switch()
            if (player1role == Role.Runner) player1Score++;
            else player2Score++;
            Switch();

        }
        
        int currentTimer = (int) Math.Ceiling(timeLeft);
        if(currentTimer!=_timerValue){
            _timerValue = currentTimer;
            updateCanvas();
        }
    }

    public void Hit(){
        // collision happened, increment score for catcher, and call switch()
        if (player1role == Role.Chaser) player1Score++;
        else player2Score++;
        Switch();
    }
	
}