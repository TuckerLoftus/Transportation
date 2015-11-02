using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {

	public int x,y ; 
	public Material WhiteColor ; 
	public Material RedColor ;
	public Material ActiveColor ;
<<<<<<< HEAD
	public Material BlackColor ; 
=======
>>>>>>> origin/master



	// Use this for initialization
	void Start () {
<<<<<<< HEAD
		MasterScript.AllCubes [0, 8].GetComponent<CubeBehavior> ().turnRed ();
		MasterScript.AllCubes[15,0].GetComponent<CubeBehavior> ().turnBlack () ; 
=======
		MasterScript.AllCubes [0, 8].GetComponent<CubeBehavior> ().turnRed (); 
>>>>>>> origin/master

	
	}
	void OnMouseDown () {
		if (x == MasterScript.ap1.x && y == MasterScript.ap1.y && MasterScript.ap1.airplaneActive == false) {
			turnActive ();
			MasterScript.ap1.airplaneActive = true; 
		} else if (x == MasterScript.ap1.x && y == MasterScript.ap1.y && MasterScript.ap1.airplaneActive == true) {
			turnRed (); 
			MasterScript.ap1.airplaneActive = false; 
<<<<<<< HEAD
		} 
		}

=======
		} else {
			if (MasterScript.ap1.airplaneActive == true) { 
				MasterScript.AllCubes[MasterScript.ap1.x, MasterScript.ap1.y].GetComponent<Renderer>().material = WhiteColor; 
				MasterScript.ap1.x = x;
				MasterScript.ap1.y = y;
					turnActive ();

				}
			}
		}





>>>>>>> origin/master

	// looks through all cubes and sets the one with the active airplane to ActiveColor 
	 



	public void turnRed () {
		GetComponent<Renderer> ().material = RedColor;
	}

	public void turnWhite () {
		GetComponent<Renderer> ().material = WhiteColor; 
	}

<<<<<<< HEAD
	public void turnActive () { 
		GetComponent<Renderer> ().material = ActiveColor; 
	}
	public void turnBlack () { 
		GetComponent<Renderer> ().material = BlackColor; 
	}

	// Update is called once per frame
	void Update () {

=======
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
>>>>>>> origin/master
		}

}
