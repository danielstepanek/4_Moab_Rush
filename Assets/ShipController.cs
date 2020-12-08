using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShipController : MonoBehaviour
{
    [Tooltip("In m/s")][SerializeField] float xSpeed;
	[Tooltip("In m/s")] [SerializeField] float ySpeed;
	[SerializeField] float pitchFactor = -3f;
	[SerializeField] float yawFactor = 3f;

	// Start is called before the first frame update
	void Start()
    {
    }

    // Update is called once per frame
    void Update()
	{
		UpdateTransform();
		UpdateRotation();
	}

	public void UpdateTransform()
	{
		float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		float yThrow = CrossPlatformInputManager.GetAxis("Vertical");

		// Position
		float xOffset = xSpeed * xThrow * Time.deltaTime;
		float yOffset = ySpeed * yThrow * Time.deltaTime;
		float rawNewXPos = Mathf.Clamp(transform.localPosition.x + xOffset, -8f, 8f);
		float rawNewYPos = Mathf.Clamp(transform.localPosition.y + yOffset, -5f, 5f);
		transform.localPosition = new Vector3(rawNewXPos, rawNewYPos, transform.localPosition.z);

		// Rotation



	}
	public void UpdateRotation()
	{
		float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		float yThrow = CrossPlatformInputManager.GetAxis("Vertical");

		float pitch = transform.localPosition.y * pitchFactor + yThrow * -10f;
		float yaw = transform.localPosition.x * yawFactor;
		float roll = xThrow * -20f;

		transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
	}
}
