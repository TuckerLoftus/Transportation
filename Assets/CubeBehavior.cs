using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {

	public int x,y ; 
	public Material WhiteColor ; 
	public Material RedColor ;
	public Material ActiveColor ;
	public Material BlackColor ; 



	// Use this for initialization
	void Start () {
		MasterScript.AllCubes [0, 8].GetComponent<CubeBehavior> ().turnRed ();
		MasterScript.AllCubes[15,0].GetComponent<CubeBehavior> ().turnBlack () ; 

	
	}
	void OnMouseDown () {
		if (x == MasterScript.ap1.x && y == MasterScript.ap1.y && MasterScript.ap1.airplaneActive == false) {
			turnActive ();
			MasterScript.ap1.airplaneActive = true; 
		} else if (x == MasterScript.ap1.x && y == MasterScript.ap1.y && MasterScript.ap1.airplaneActive == true) {
			turnRed (); 
			MasterScript.ap1.airplaneActive = false; 
		} 
		}


	// looks through all cubes and sets the one with the active airplane to ActiveColor 
	 



	public void turnRed () {
		GetComponent<Renderer> ().material = RedColor;
	}

	public void turnWhite () {
		GetComponent<Renderer> ().material = WhiteColor; 
	}

	public void turnActive () { 
		GetComponent<Renderer> ().material = ActiveColor; 
	}
	public void turnBlack () { 
		GetComponent<Renderer> ().material = BlackColor; 
	}

	// Update is called once per frame
	void Update () {

		}

}
