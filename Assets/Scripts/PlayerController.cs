using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Velocidad a la que se tiene que mover el personaje
    public float speed= 4.0f; //Para mover a una velocidad constante

    //Guardar constantes que controlen el movimiento horzontal y vertical
    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (El update se llama una vez por frame
    void Update()
    {
        //Interpretar sentencias de control s = v*t espacio es igual a velocidad por tiempo
       if(Mathf.Abs(Input.GetAxis(horizontal)) > 0.5f)
        {
            this.transform.Translate(new Vector3(Input.GetAxisRaw(horizontal) * speed * Time.deltaTime,0,0));
        }
       if (Mathf.Abs(Input.GetAxis(vertical)) > 0.5f)
        {
            this.transform.Translate(new Vector3(0, Input.GetAxisRaw(vertical) * speed * Time.deltaTime, 0));
        }

    }
}
