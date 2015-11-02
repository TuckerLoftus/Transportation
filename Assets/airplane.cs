using UnityEngine;
using System.Collections;

public class Airplane {

	public bool airplaneActive = false; 
	public int x,y ; 
<<<<<<< HEAD
	public int cargoMax = 90; 
	public int cargoHold = 0  ;


	public int nextX = 0 ; 
	public int nextY = 0 ; 


	public void Move () { 
		x += nextX; 
		y += nextY;
		nextX = 0 ;
		nextY = 0; 
=======
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
>>>>>>> origin/master
	
	public void Move () { 
		x += xMovement ; 
		y += yMovement; 
	}

	public void SetMovementDirection (int xValue, int yValue ) {
		nextX = xValue; 
		nextY = yValue; 
	}














	void Start () {
	
<<<<<<< HEAD
=======














	void Start () {
	
>>>>>>> origin/master
	}

	void Update () {
	
	}





}
