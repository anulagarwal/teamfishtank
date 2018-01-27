using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	[SerializeField]
	public int ammo;

	[SerializeField]
	public Rigidbody bullet;

	[SerializeField]
	public float speed;

	// Use this for initialization
	void Start () {
		
	}


	public void shootBullet(){
		if (ammo > 0) {
			Rigidbody bulleta = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
			bulleta.velocity  = transform.TransformDirection (new Vector3 (0, 0, -speed));
			ammo -= 1;

		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {


			shootBullet ();
		}
	}
}
