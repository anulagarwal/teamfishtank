using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : MonoBehaviour {
	[SerializeField]
	public float radius;

	[SerializeField]
	List<Planets> planetsInRange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	emitTransmission ();
	}

	public void emitTransmission(){

			GetComponent<Player> ().hasReceivedTransmission = false;
			RaycastHit hit;

			Collider[] col = Physics.OverlapSphere (transform.position, radius);
			int i = 0;
			planetsInRange.Clear ();
			while (i < col.Length) {
				if (col [i].gameObject.layer == 9) {

					planetsInRange.Add (col [i].gameObject.GetComponent <Planets> ());
				}

				i++;
			}
			foreach (Planets pla in planetsInRange) {
			GameObject tempO = GetComponent<Player> ().gm.rayObj;
			GameObject go = Instantiate (tempO, transform.position, tempO.transform.rotation);
				go.GetComponent<RayObj> ().moveAndDestroy (pla.transform, 9);
			}


	}


	public void receiveTransmission(){


	}

}
