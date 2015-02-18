using UnityEngine;
using System.Collections;

public class DebugMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void WriteToLog(string text)
	{
		Debug.Log(text);
	}
}
