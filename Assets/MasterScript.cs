using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {

	public Material RedColor ;
	public GameObject fatherCube; 
	public GameObject Cube;
	public static GameObject [,] AllCubes = new GameObject[16,9] ; 
	public static Airplane ap1 ;
	public float turnTime = 1.5f ;
<<<<<<< HEAD
	public float cycleTime ;

	public void CheckKeyInput () {
		if (Input.GetKey ("up") && ap1.y < 8) {
			ap1.SetMovementDirection (0,1) ;
		}
		if (Input.GetKey ("down")&& ap1.y > 0) {
			ap1.SetMovementDirection (0,-1) ;
		}
		if (Input.GetKey ("right")&& ap1.x < 15) {
			ap1.SetMovementDirection (1,0) ;
			print ("right ") ; 
		}
		if (Input.GetKey ("left")&& ap1.x > 0) {
			ap1.SetMovementDirection (-1,0) ;
			print ("left") ; 
		}
		
	}
	public int score = 0; 

=======
	public float cycleTime ; 
>>>>>>> origin/master



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
<<<<<<< HEAD

				}
			}
		} 

	public void ActualizeMovement () {
		MasterScript.AllCubes[ap1.x,ap1.y].GetComponent<CubeBehavior> ().turnWhite () ;

		MasterScript.ap1.Move();


		MasterScript.AllCubes[ap1.x,ap1.y].GetComponent<CubeBehavior> ().turnActive () ; 

		if (ap1.x != 15 || ap1.y != 0) {
			AllCubes[15,0].GetComponent<CubeBehavior> ().turnBlack () ; 
		}
				}
			





	// Update is called once per frame
	void Update () {
		CheckKeyInput (); 
		cycleTime += Time.deltaTime;

		if ( cycleTime > turnTime ) { 
			cycleTime = 0;
		if (ap1.airplaneActive == true) {
			ActualizeMovement () ;
		}
			if (ap1.x == 0 && ap1.y == 8 ) {
				if (ap1.cargoHold < ap1.cargoMax ) {
					ap1.cargoHold += 10;
					print ("score is" + ap1.cargoHold) ;
				}

			}
			if (ap1.x == 15 && ap1.y == 0) {
				score = ap1.cargoHold ;
				ap1.cargoHold = 0 ;
				print ("score is" + score) ;
			}

		}
=======
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

	
>>>>>>> origin/master
	}
}
