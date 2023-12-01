using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animation_Boton : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Demo");
    }
}