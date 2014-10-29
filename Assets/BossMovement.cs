using UnityEngine;
using System.Collections;

public class BossMovement : MonoBehaviour 
{
	private bool goingDownwards = true;
	private float movement = 0.005f;
	private float limit = 0.1f;
	// Use this for initialization
	void Start () 
	{
		//downwardsForce = new Vector2(0, -movementForce);
		//upwardsForce = new Vector2(0, movementForce);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//this.transform.position = new Vector3 (0, this.transform.position.y+0.01f,0);
		if (goingDownwards) 
		{
			if (this.rigidbody2D.position.y > -limit) 
			{
				this.transform.position = new Vector3 (0, this.transform.position.y - movement, 0);
			}
			else
			{
				goingDownwards = !goingDownwards;
			}
		}
		else
		{
			if (this.rigidbody2D.position.y < limit) 
			{
				this.transform.position = new Vector3 (0, this.transform.position.y + movement, 0);
			} 
			else 
			{
				goingDownwards = !goingDownwards;
			}
		}
	}
}
