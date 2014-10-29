using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	//bool clockWise = true;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		short keyPressed = 0;
		//Touch elTouch = Input.GetTouch (0);
		//GameObject obj = GameObject.Find ("Player");

		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			keyPressed = -1;
		}
		else if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
			keyPressed = 1;
		}
		if(keyPressed != 0)
		{
			HingeJoint2D joint = this.GetComponent<HingeJoint2D>();
			JointMotor2D motor = joint.motor;
			motor.motorSpeed = 100 * keyPressed;
			joint.motor = motor;
		}
	}
}
