using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	static public inventario _inventarioController;
	public GameObject inventario;

	// Use this for initialization
	void Start () {
		_inventarioController = inventario.GetComponent<inventario> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
