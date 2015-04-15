using UnityEngine;
using System.Collections;

public class boxColor : MonoBehaviour
{

	public Color color;
	
	// Use this for initialization
	void Start ()
	{
		foreach (Renderer rend in GetComponentsInChildren<Renderer> ())
		{
			rend.material.SetColor ("_Color", color);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
