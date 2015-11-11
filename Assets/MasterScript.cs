using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {

	public Material RedColor ;
	public GameObject fatherCube; 
	public GameObject Cube;
	public static GameObject [,] AllCubes = new GameObject[16,9] ; 
	public static Airplane ap1 ;
	public static Train tr1 ;
	public float FastTime = 1.5f ;
	public float cycleTime ;
	public int score = 0;
	public int startX = 0 ; 
	public int startY = 8 ; 

	void SpawnCube (int x, int y) {
		AllCubes[x,y]  = (GameObject) Instantiate (Cube, new Vector3 ((x * 2), y * 2), Quaternion.identity);
		AllCubes [x,y].transform.parent = fatherCube.transform;	
		AllCubes [x,y].GetComponent<CubeBehavior> ().x = x;
		AllCubes [x,y].GetComponent<CubeBehavior> ().y = y;
	}

	
	// Use this for initialization
	void Start () {
		ap1 = new Airplane () ;
		ap1.x = startX; 
		ap1.y = startY;
		ap1.destX = startX; 
		ap1.destY = startY;


		ap1.cargoHold = 0;
		for (int y = 0; y <  9; y++) {
			for (int x = 0; x < 16;x++) { 
			SpawnCube (x,y);
				}
			}
		} 

	public void ActualizeAirplaneMovement () {
		int xMovement = 0 ; 
		int yMovement = 0; 
		if (ap1.destX != ap1.x || ap1.destY != ap1.y) {
			if (ap1.destX > ap1.x ) {
				xMovement = 1 ; 
			}
			if (ap1.destX < ap1.x ) {
				xMovement = -1 ; 
			}
			if (ap1.destX == ap1.x ) {
				xMovement = 0 ; 
			}
			if (ap1.destY > ap1.y ) {
				yMovement = 1 ; 
			}
			if (ap1.destY < ap1.y ) {
				yMovement = -1 ; 
			}
			if (ap1.destY == ap1.y ) {
				yMovement = 0 ; 
			}
			ap1.SetMovementDirection(xMovement, yMovement) ;

		}


		MasterScript.AllCubes[ap1.x,ap1.y].GetComponent<CubeBehavior> ().turnWhite () ;

		MasterScript.ap1.Move();


		MasterScript.AllCubes[ap1.x,ap1.y].GetComponent<CubeBehavior> ().turnActive () ; 

		if (ap1.x != 15 || ap1.y != 0) {
			AllCubes[15,0].GetComponent<CubeBehavior> ().turnBlack () ; 
		}
	}  


	// Update is called once per frame
	void Update () {
		cycleTime += Time.deltaTime; 
		if (cycleTime > FastTime) { 
			cycleTime = 0f;
			if (ap1.airplaneActive == true) {
				ActualizeAirplaneMovement ();
			}
			if (ap1.x == 0 && ap1.y == 8) {
				if (ap1.cargoHold < ap1.cargoMax) {
					ap1.cargoHold += 10;
					print ("Airplane Cargo is" + ap1.cargoHold);
				}

			}
			if (ap1.x == 15 && ap1.y == 0) {
				score = ap1.cargoHold;
				ap1.cargoHold = 0;
				print ("score is" + score);
			}

		}
		
	}
				
	}

	