using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // To access the btns 
using UnityEngine.SceneManagement;         // used to switch scens in game


public class MenuScript : MonoBehaviour
{

    public InputField UsernameText;
    public GameObject Startbtn;

     void Start() {
        Startbtn.SetActive(false);
        
    }
    


    // Update is called once per frame
    void Update()
    {
        if(UsernameText.text.Length >= 1){
            Startbtn.SetActive(true);   // Setactive is for enable or disable    
        }
        else{
          Startbtn.SetActive(false); 
        }
    }

   public void OnStartPressed(){

       SceneManager.LoadScene("Spinner"); 
       
    }
} //class
