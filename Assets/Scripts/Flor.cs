using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    
using UnityEngine.SceneManagement;         


public class Flor : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D flor)
    {
        // Debug.Log("OnCollisionEnter2D");
        SceneManager.LoadScene("Menu");
    }

}

