using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [Tooltip("In m/s")][SerializeField] float xSpeed = 10f;
	[Tooltip("In m/s")] [SerializeField] float ySpeed = 8f;
	[SerializeField] float pitchFactor = -3f;
	[SerializeField] float yawFactor = 3f;
	Rigidbody rigidBody;
	bool isControlEnabled = true;


	// Start is called before the first frame update

    // Update is called once per frame
    void Update()
	{
		if (isControlEnabled == true)
		{
			UpdateTransform();
			UpdateRotation();
		}

	}


	void OnPlayerDeath()
	{
		print("Death");
		isControlEnabled = false;
	}
	public void UpdateTransform()
	{
		float xThrow = Input.GetAxis("Horizontal");
		float yThrow = Input.GetAxis("Vertical");



		// Position on Screen
		float xOffset = xSpeed * xThrow * Time.deltaTime;
		float yOffset = ySpeed * yThrow * Time.deltaTime;
		float rawNewXPos = Mathf.Clamp(transform.localPosition.x + xOffset, -8f, 8f);
		float rawNewYPos = Mathf.Clamp(transform.localPosition.y + yOffset, -5f, 5f);
		transform.localPosition = new Vector3(rawNewXPos, rawNewYPos, transform.localPosition.z);

		// Rotation



	}
	private void OnTriggerEnter(Collider other)
	{
		
	}
	public void UpdateRotation()
	{
		float xThrow = Input.GetAxis("Horizontal");
		float yThrow = Input.GetAxis("Vertical");
		

		float pitch = transform.localPosition.y * pitchFactor + yThrow * -10f;
		float yaw = transform.localPosition.x * yawFactor;
		float roll = xThrow * -20f;

		transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
	}
}
