using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
	[SerializeField] private Transform cameraTransform;

	private void LateUpdate()
	{
		transform.LookAt(transform.position + cameraTransform.forward);
	}
}
