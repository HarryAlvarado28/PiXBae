using UnityEngine;

public class FollowThePath : MonoBehaviour {

    // Number of waypoints in the board
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f; // Speed of the spaceship

    [HideInInspector]
    public int waypointIndex = 0; // Index of the waypoint array

    public bool moveAllowed = false;

	// Use this for initialization
	private void Start () {
        transform.position = waypoints[waypointIndex].transform.position;
	}
	
	// Update is called once per frame to check if the player can move
	private void Update () {
        if (moveAllowed)
            Move();
	}


    // This is to move the player to the indexed waypoint
    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
