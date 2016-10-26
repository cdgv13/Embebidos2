using UnityEngine;
using System.Collections;

public class CamaraControl : MonoBehaviour {

    public GameObject Jugador;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Jugador.transform.position.x + 5, transform.position.y, transform.position.z);
	
	}
}
