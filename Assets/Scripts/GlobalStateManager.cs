using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlobalStateManager : MonoBehaviour
{

    private int deadPlayers = 0;
    private int deadPlayerNumber = -1;  

    public Text messageText = null  ; 

    public void PlayerDied (int playerNumber)
    {
        deadPlayers++; // 1

        if (deadPlayers == 1) 
        { // 2
            deadPlayerNumber = playerNumber; // 3
            Invoke("CheckPlayersDeath", .3f); // 4
        }  
        
    }

    void CheckPlayersDeath() 
    {
        messageText.text = "" ;
        
        if (deadPlayers == 1) 
        { 
            
            if (deadPlayerNumber == 1) 
            { 
                messageText.text = "Player 2 is the winner!";
            } 
            else 
            { 
                messageText.text = "Player 1 is the winner!";
            }
        } 
        else 
        { 
            messageText.text = "The game ended in a draw!" ;
        }
    }  

}
