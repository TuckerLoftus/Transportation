using UnityEngine;
using System.Collections;

public class Airplane {

	public bool airplaneActive = false; 
	public int x,y ; 
	public int cargoHold ;
	public enum directions {
		up,
		down,
		left,
		right 
	} 
	
	private int xMovement = 0;
	private int yMovement = 0;
	
	
	
	
	
	
	public void setMoveDirection (int xMove, int yMove) {
		if (Input.GetKey ("up")) 
			yMove = 1;
		if (Input.GetKey ("down"))
			yMove = -1;
		if (Input.GetKey ("right"))
			xMove = 1;
		if (Input.GetKey ("left"))
			xMove = -1;
		xMove = xMovement; 
		yMove = yMovement; 
	}
	
	public void Move () { 
		x += xMovement ; 
		y += yMovement; 
	}
	














	void Start () {
	
	}

	void Update () {
	
	}





}
