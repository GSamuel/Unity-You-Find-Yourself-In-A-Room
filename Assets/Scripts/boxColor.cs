using UnityEngine;
using System.Collections;

public class boxColor : MonoBehaviour
{

	public Color color;
	public bool randomColor = false;
	
	// Use this for initialization
	void Start ()
	{
		UpdateColor();
	}

	private void UpdateColor()
	{
		foreach (Renderer rend in GetComponentsInChildren<Renderer> ())
		{
			if(randomColor)
				rend.material.SetColor ("_Color", RandomColor());
			else 
				rend.material.SetColor ("_Color", color);
		}
	}

	private Color RandomColor()
	{
		return new Color(Random.Range(0,1.0f),Random.Range(0,1.0f),Random.Range(0,1.0f),1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//UpdateColor();
	}
}
