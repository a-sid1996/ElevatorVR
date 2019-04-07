using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movinglift : MonoBehaviour {

	public Transform movingLift;
	public Transform position0;
	public Transform position1;
	public Transform position2;
	public Transform position3;
	public Transform position4;

	
	
	public Vector3 newPosition;
	public string currentState;
	public float smooth;

	// Use this for initialization
	void Start () {
		currentState = "Moving from position 0";
		nextState();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movingLift.position = Vector3.Lerp (movingLift.position, newPosition, smooth * Time.deltaTime);
	}
	
	void nextState(){
		if(currentState == "Moving from position 0"){
			currentState = "Moving up to position 1";
			newPosition = position1.position;	
		} else if(currentState == "Moving up to position 1"){
			currentState = "Moving up to position 2";
			newPosition = position2.position;	
		} else if(currentState == "Moving up to position 2"){
			currentState = "Moving up to position 3";
			newPosition = position3.position;
		} else if(currentState == "Moving up to position 3"){
			currentState = "Moving up to position 4";
			newPosition = position4.position;
		} else if(currentState == "Moving up to position 4"){
			currentState = "Moving down to position 3";
			newPosition = position3.position;
		} else if(currentState == "Moving down to position 3"){
			currentState = "Moving down to position 2";
			newPosition = position2.position;
		} else if(currentState == "Moving down to position 2"){
			currentState = "Moving down to position 1";
			newPosition = position1.position;
		} else if(currentState == "Moving down to position 1"){
			currentState = "Moving from position 0";
			newPosition = position0.position;
		} 
		Invoke("nextState",7);
	}	
}
