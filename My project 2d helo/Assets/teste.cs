using UnityEngine;

public class teste : MonoBehaviour

{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        //Debug.log(numero);
        //numero = numero + 1

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
        }
    }
}
