using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField] float movementSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool movement = Input.GetKey(KeyCode.K);
		// Position in World
		float offset = movementSpeed * Time.deltaTime;

        if (movement == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);

        }

    }
}
