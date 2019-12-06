using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public static GameLogic Instance { get; set; }
    public float timeLeft = 10;
    public int gameCount = 0;

     function Update()
    {
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
            gameCount++;
            timeLeft = 10;
            if(gameCount == 10){
                Debug.Log("Game Over");
            }
        }
    }
    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;
	}
	
}