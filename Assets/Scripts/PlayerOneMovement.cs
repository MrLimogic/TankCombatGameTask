using UnityEngine;
using System.Collections;

[System.Serializable] //Makes this class seeable by unity.
public class Boundary //Doesn't have MonoBehaviour after it because it doesnt inhert any behaviours from that class.
{
    //Contains the min and max values for the x and y axies
    public float xMin, xMax, yMin, yMax;
}

public class NewBehaviourScript : MonoBehaviour
{

    public int playerOneSpeed; //Player Ones speed
    public float playerOneMaxSpeed = 3; //Player Ones Top Speed
    public float playerOneVelocity; 

    public int angleRotation = 0;

    Camera myGameCamera;

    Vector3 playerPosition;

	// Use this for initialization
	void Start ()
    {
	
	}

    void PositionUpdate()
    {

    }

    void Movement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal"); //gets the axis of input
        float verticalMovement = Input.GetAxis("Vertical"); //gets the axis of input
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Movement();
	}
}
