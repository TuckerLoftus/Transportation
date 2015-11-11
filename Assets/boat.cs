using UnityEngine;
using System.Collections;

public class Boat {
	
	public bool boatActive = false; 
	public int x,y ;
	public int cargoMax = 550; 
	public int cargoHold = 0  ;
	
	
	public int nextX = 0 ; 
	public int nextY = 0 ; 
	
	
	public void Move () { 
		x += nextX; 
		y += nextY;
		nextX = 0;
		nextY = 0; 
		
	}
	
	
	
	
	
	public void SetMovementDirection (int xValue, int yValue ) {
		nextX = xValue; 
		nextY = yValue; 
	}
	
	
	
	
	
	
}





