using UnityEngine;
using System.Collections;

public class Cubo : MonoBehaviour {

	public float velocidad;
	public float maxLeft;
	public float maxRight;

	Transform myTransform;
	int sentido;


	// Use this for initialization
	void Start () {
		myTransform = this.transform;
		if (velocidad == 0)
						velocidad = 1;
		if (maxLeft == 0)
						maxLeft = -0.6f;
		if (maxRight == 0)
						maxRight = 0.6f;

		sentido = 1;

	}
	
	// Update is called once per frame
	void Update () {

		if (((myTransform.position.x <= maxLeft) && (sentido == -1)) 
		    ||
		    (( myTransform.position.x >= maxRight) && (sentido == 1)))
		{
			sentido *= -1;
		}

		myTransform.Translate (Vector3.right * velocidad * sentido * Time.deltaTime);

	}
}
