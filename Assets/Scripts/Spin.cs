using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //

public class Spin : MonoBehaviour
{

    public GameObject Spinbtn;
    public GameObject NO_7;
    public GameObject NO_9;
    public GameObject NO_13;
    public GameObject NO_15;
    public GameObject NO_19;
    public GameObject NO_22;
    public GameObject NO_28;

    // Start is called before the first frame update
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space)){
            transform.Rotate(0f, 0f, -100000f * Time.deltaTime, Space.Self);
        }

        else if(Input.GetKeyDown(KeyCode.Space)){
            transform.Rotate(0f, 0f, 0f, Space.Self);

        }
       
      
    }

    public void Onclick_No_7(){
        SceneManager.LoadScene("Samplescene");
    }
    public void Onclick_No_9(){
        SceneManager.LoadScene("Level 9");
    }
    public void Onclick_No_13(){
        SceneManager.LoadScene("Level 13");
    }
    public void Onclick_No_15(){
        SceneManager.LoadScene("Level 15");
    }
    public void Onclick_No_19(){
        SceneManager.LoadScene("Level 19");
    }
    public void Onclick_No_22(){
        SceneManager.LoadScene("Level 22");
    }
    public void Onclick_No_28(){
        SceneManager.LoadScene("Level 28");
    }
}//class
