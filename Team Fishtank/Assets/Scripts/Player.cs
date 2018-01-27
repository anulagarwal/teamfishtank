using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float fuel;

	public float health;


	public List<Quest> quests;

	public bool hasReceivedTransmission;
	public enum States
	{
Idle,
Forward,
Backward,
Upward,
Shooting,
	Dash}

	;

	public List<Galaxies.Classes> alliances;


	public Planets currentPlanet;


	public Sector currentSector;

	public GameManager gm;
	public QuestManager qm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void movePlayer(){


	}

	void shoot(){


	}

	void interactWithPlanet(){

	}
	void checkForRetrieveQuests(Planets plane){

		foreach (Quest q in quests) {

			if (q.questGivenBy == plane && q.isRetrievable && q.hasRetrieved) {

				qm.completeQuest (q);
				quests.Remove (q);
			}
		}

	}


	public void receiveTransmissionBack(){


		hasReceivedTransmission = true;
	
	}
	void checkForQuestForObject(GameObject go){
		
		foreach (Quest q in quests) {

			if (q.questObject == go) {
				//for no ret
				if (!q.isRetrievable) {

					qm.completeQuest (q);
					quests.Remove (q);
					Destroy (go);
				} else {

					q.hasRetrieved = true;
					Destroy (go);


				}


				break;
			}

		}

	}
	//WASD Control scheme
	void checkForControls(){

		if(Input.GetKey(KeyCode.W)){



		}
	
		if(Input.GetKey(KeyCode.A)){



		}
		if(Input.GetKey(KeyCode.S)){



		}
		if(Input.GetKey(KeyCode.D)){



		}


	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.layer == 9) {
			currentPlanet = col.gameObject.GetComponent<Planets> ();
			checkForRetrieveQuests ( col.gameObject.GetComponent<Planets> ());
		}

		if (col.gameObject.layer == 10) {

			checkForQuestForObject (col.gameObject);
		}

	}
	void OnTriggerExit(Collider col){

		if (col.gameObject.layer == 9) {
			currentPlanet =null;

		}


	}
}
