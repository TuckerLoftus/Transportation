using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {


	public GameObject Cube ;
	public static GameObject [] AllCubes = new GameObject[16] ; 

	void SpawnCube (float x) {
		AllCubes[(int)x]  = (GameObject) Instantiate (Cube, new Vector3 ((x * 2), 0), Quaternion.identity);

	}

	// Use this for initialization
	void Start () {
		for (int x = 0; x < 16; x++) {
			SpawnCube (x);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
