using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D collisionador)
    {
        if (collisionador.gameObject.tag == "Player") {
            //Cambiar de escena game over.
            Debug.Break();
            
        }

        else
        {
            if (collisionador.gameObject.transform.parent)
                Destroy(collisionador.gameObject.transform.parent.gameObject);
            else
                Destroy(collisionador.gameObject);
        }
    }

}
