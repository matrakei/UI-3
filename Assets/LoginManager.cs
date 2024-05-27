using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{

    public string contrasenia = manzana;
    public InputField inputPassword;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckPassword()
    {
        if (inputPassword.text == contrasenia)
        {
            Debug.Log("Access granted");
        }
        else 
        {
            Debug.Log("Access denied");
        }
    }



}
