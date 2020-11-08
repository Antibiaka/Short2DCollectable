using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightCOntroller : MonoBehaviour
{
	// Start is called before the first frame update
	private float interpVelocity;
	public GameObject target;
	Vector3 targetPos;


	void Start() {
		targetPos = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate() {
		if (target) {
			Vector3 posNoZ = transform.position;
			posNoZ.z = target.transform.position.z;

			Vector3 targetDirection = (target.transform.position - posNoZ);

			interpVelocity = targetDirection.magnitude * 100f;

			targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

			transform.position = Vector3.Lerp(transform.position, targetPos, 0.65f);

		}
	}
}
