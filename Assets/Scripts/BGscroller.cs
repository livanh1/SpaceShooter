using UnityEngine;
using System.Collections;

public class BGscroller : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSize;

	private Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;
        tileSize = transform.localScale.y;
	}

	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSize);
		transform.position = startPosition + Vector3.forward * newPosition;
	}
}