using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {


    private static GameObject player1;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {

        
   
       
        // Find the spaceship from the player 1
        player1 = GameObject.Find("Player1");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        // This is to hold the spaceship when it reaches the end
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }




    }

    // It allows the player to move
    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
}
