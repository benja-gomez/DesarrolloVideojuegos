using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValidateUser : MonoBehaviour
{

    public Text CajaNombre, CajaEdad;
    string nombre;
    byte edad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Validate(){
        //Solo si es mayor de edad
        nombre = CajaNombre.text;
        edad = byte.Parse(CajaEdad.text);
        Debug.Log(nombre);
        Debug.Log(edad);
        if(edad>=18){
            
        SceneManager.LoadScene("Level0");
        }
        else{
            Debug.Log($"Tas chiquito mano, tu edad es {edad}");
        }
    }

}
