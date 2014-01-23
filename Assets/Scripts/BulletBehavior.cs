using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	public float velocityFactor;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().velocity = this.transform.forward*velocityFactor;
		Debug.Log ("I'm flying!");
		GameObject.Destroy (this.gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
