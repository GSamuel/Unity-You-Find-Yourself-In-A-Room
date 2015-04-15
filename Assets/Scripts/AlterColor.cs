using UnityEngine;
using System.Collections;

public class AlterColor : MonoBehaviour {

	public Color color;

	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		rend.material.SetColor("_EmisColor", color);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
