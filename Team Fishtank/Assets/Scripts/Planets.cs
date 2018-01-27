using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour {
	[SerializeField]
	GameManager gm;

		[SerializeField]
	DialogManager dm;



	[SerializeField]
	public Galaxies.Classes alliance;

	[SerializeField]
	public List<DialogueSequence> dialogues;


	[SerializeField]
	GameObject tempO;

	[SerializeField]
	int playerVisits;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime *1.5f, Space.World);
	}

	void sendMessageToShip(){



	}
	public void receiveTransmission(){

	//	GameObject rayO = Instantiate (gm.rayObj, transform.position, Quaternion.identity);
	//	Debug.DrawLine (transform.position, gm.player.transform.position);
	
		GameObject go = Instantiate (tempO, transform.position,tempO.transform.rotation);
	
		go.GetComponent<RayObj> ().moveAndDestroy (gm.player.transform, 8);

	}
	void OnTriggerEnter(Collider col){


		if (col.gameObject.layer == 8) {
			if (playerVisits < dialogues.Count) {
				if (!dialogues [playerVisits].hasRead) {
					dm.displaySequence (dialogues [playerVisits], this);
					dialogues [playerVisits].hasRead = true;
				}
			
				playerVisits += 1;
			}
		}

	}
}
