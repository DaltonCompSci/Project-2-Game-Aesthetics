using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Control : MonoBehaviour
{

    
    public void RestartGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().BuildIndex());
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}