using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	public GameObject bullet;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) {
			GameObject myBullet;
			myBullet = GameObject.Instantiate(bullet, this.transform.position+this.transform.forward*0.5f, this.transform.rotation) as GameObject;
		}	

	}
}
