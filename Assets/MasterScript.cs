using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {

	public Material RedColor ;
	public GameObject fatherCube; 
	public GameObject Cube;
	public static GameObject [,] AllCubes = new GameObject[16,9] ; 
	public static Airplane ap1 ;
	public float turnTime = 1.5f ;
	public float cycleTime ; 



	void SpawnCube (int x, int y) {
		AllCubes[x,y]  = (GameObject) Instantiate (Cube, new Vector3 ((x * 2), y * 2), Quaternion.identity);
		AllCubes [x,y].transform.parent = fatherCube.transform;	
		AllCubes [x,y].GetComponent<CubeBehavior> ().x = x;
		AllCubes [x,y].GetComponent<CubeBehavior> ().y = y;
	}

	
	// Use this for initialization
	void Start () {
		ap1 = new Airplane () ;
		ap1.x = 0; 
		ap1.y = 8;
		ap1.cargoHold = 0; 
		for (int y = 0; y <  9; y++) {
			for (int x = 0; x < 16;x++) { 
			SpawnCube (x,y);
				if (ap1.x == x && ap1.y == y) {
					AllCubes[x,y].GetComponent<Renderer> ().material = RedColor ;   

				}
			}
		}
	} 
	
	// Update is called once per frame
	void Update () {
		Time.deltaTime += cycleTime;
		if ( cycleTime > turnTime ) {
			MasterScript.ap1.Move(); 
			cycleTime = 0; 

	
	}
}
