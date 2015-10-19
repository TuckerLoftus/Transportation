using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {

	public Material WhiteColor ; 
	public Material RedColor ;

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown () {
		for (int x = 0; x< MasterScript.AllCubes.Length; x++) {
			MasterScript.AllCubes [x].GetComponent<CubeBehavior> ().turnWhite() ; 
		}
		turnRed (); 

	}

	void turnRed () {
		GetComponent<Renderer> ().material = RedColor;
	}

	public void turnWhite () {
		GetComponent<Renderer> ().material = WhiteColor; 
	}

	// Update is called once per frame
	void Update () {
	
	}
}
