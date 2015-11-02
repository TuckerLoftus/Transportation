using UnityEngine;
using System.Collections;

public class Airplane {

	public bool airplaneActive = false; 
	public int x,y ; 
	public int cargoMax = 90; 
	public int cargoHold = 0  ;


	public int nextX = 0 ; 
	public int nextY = 0 ; 


	public void Move () { 
		x += nextX; 
		y += nextY;
		nextX = 0 ;
		nextY = 0; 
	
	}

	public void SetMovementDirection (int xValue, int yValue ) {
		nextX = xValue; 
		nextY = yValue; 
	}














	void Start () {
	
	}

	void Update () {
	
	}





}
