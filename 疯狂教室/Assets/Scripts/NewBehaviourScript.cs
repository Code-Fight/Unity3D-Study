using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private Transform t_students;
	// Use this for initialization
	void Start () {
		t_students = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		//前进
		if (Input.GetKey (KeyCode.W)) {
			t_students.Translate (Vector3.forward * 0.1f, Space.Self);
		}

		//后退
		if (Input.GetKey (KeyCode.S)) {
			t_students.Translate (Vector3.back * 0.1f, Space.Self);
		}

		//左移
		if (Input.GetKey (KeyCode.A)) {
			t_students.Translate (Vector3.left * 0.1f, Space.Self);
		}

		//右移
		if (Input.GetKey (KeyCode.D)) {
			t_students.Translate (Vector3.right * 0.1f, Space.Self);
		}


	}
}
