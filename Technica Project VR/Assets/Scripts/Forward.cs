using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{

	Vector3 End_pos;
	Vector3 Start_pos;
	public float fraction_of_way_there;
	private float distance_from_user = 1.0f;


	// Start is called before the first frame update
	void Start()
	{
		Start_pos = transform.position;
		End_pos = transform.position + new Vector3(0, 0, distance_from_user);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			BringForward();
		}
	}

	void BringForward()
	{
		fraction_of_way_there += 0.01f;
		transform.position = Vector3.Lerp(Start_pos, End_pos, fraction_of_way_there);
	}
}
