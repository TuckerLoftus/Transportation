using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {

	public int x,y ; 
	public Material WhiteColor ; 
	public Material RedColor ;
	public Material ActiveColor ;



	// Use this for initialization
	void Start () {
		MasterScript.AllCubes [0, 8].GetComponent<CubeBehavior> ().turnRed (); 

	
	}
	void OnMouseDown () {
		if (x == MasterScript.ap1.x && y == MasterScript.ap1.y && MasterScript.ap1.airplaneActive == false) {
			turnActive ();
			MasterScript.ap1.airplaneActive = true; 
		} else if (x == MasterScript.ap1.x && y == MasterScript.ap1.y && MasterScript.ap1.airplaneActive == true) {
			turnRed (); 
			MasterScript.ap1.airplaneActive = false; 
		} else {
			if (MasterScript.ap1.airplaneActive == true) { 
				MasterScript.AllCubes[MasterScript.ap1.x, MasterScript.ap1.y].GetComponent<Renderer>().material = WhiteColor; 
				MasterScript.ap1.x = x;
				MasterScript.ap1.y = y;
					turnActive ();

				}
			}
		}






	void turnRed () {
		GetComponent<Renderer> ().material = RedColor;
	}

	public void turnWhite () {
		GetComponent<Renderer> ().material = WhiteColor; 
	}

	void turnActive () { 
		GetComponent<Renderer> ().material = ActiveColor; 
	}

	// Update is called once per frame
	void Update () {
		Time.deltaTime += cycleTime;
		if ( cycleTime > turnTime ) {
			MasterScript.ap1.Move; 
			cycleTime = 0; 
		}
		}

}
