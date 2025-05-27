using UnityEngine;

public class qustao : MonoBehaviour
{
    private int resposta; 
    
   void Start()
   {
       resposta = 0;
       
   }

  
    void Update()
    {
        if(Input .GetKeyDown(KeyCode.A))
        {
            resposta = 1;
        }

        {
            if (Input .GetKeyDown(KeyCode.B))
                resposta = 2;
        }
        
        {
            if  (Input.GetKeyDown(KeyCode.C))
                resposta = 3;
        }
        
    }
    
}
