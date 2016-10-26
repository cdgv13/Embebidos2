using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {

    public GameObject[] objetos;
    public float min = .8f;
    public float max= 1f;

	// Use this for initialization
	void Start () {
        Instanciar();
	}
	
	void Instanciar()
    {
        Instantiate(objetos[Random.Range(0, objetos.Length)], transform.position, Quaternion.identity);
        Invoke("Instanciar", Random.Range(min, max));
    }
}
