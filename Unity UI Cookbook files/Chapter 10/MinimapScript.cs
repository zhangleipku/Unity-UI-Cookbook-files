using UnityEngine;
using System.Collections;

public class MinimapScript : MonoBehaviour {

	public Transform playerTransform;

	public Transform compass;

	public Vector2 xBoundaries;
	public Vector2 zBoundaries;

	public Light[] lightsNotRendered;
	public Light[] lightsNoShadowsRendered;
	public Light[] minimapLights;

	public float compassOrientationOffset = 0f;
	public float compassRotationSpeed = 1f;
	
	void Update () {
		float newXPosition = playerTransform.position.x;
		float newZPosition = playerTransform.position.z;

		if (newXPosition < xBoundaries.x)
			newXPosition = xBoundaries.x;
		if (newXPosition > xBoundaries.y)
			newXPosition = xBoundaries.y;

		if (newZPosition < zBoundaries.x)
			newZPosition = zBoundaries.x;
		if (newZPosition > zBoundaries.y)
			newZPosition = zBoundaries.y;

		transform.position = new Vector3 (newXPosition, transform.position.y, newZPosition);
		transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x,playerTransform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z));

		compass.rotation = Quaternion.Lerp (compass.rotation, Quaternion.Euler (0, 0, playerTransform.rotation.eulerAngles.y+compassOrientationOffset), Time.deltaTime * compassRotationSpeed);
	}

	void OnPreCull (){
		foreach(Light l in lightsNotRendered)
			l.enabled = false;

		foreach(Light l in lightsNoShadowsRendered)
			l.shadows = LightShadows.None;

		foreach(Light l in minimapLights)
			l.enabled = true;
	}

	void OnPostRender(){
		foreach(Light l in lightsNotRendered)
			l.enabled = true;
		
		foreach(Light l in lightsNoShadowsRendered)
			l.shadows = LightShadows.Soft;
		
		foreach(Light l in minimapLights)
			l.enabled = false;
	}
}
