using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHomeScreen : MonoBehaviour
{
    //public AudioSource audioSource;
    //public AudioClip quitClickSound;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    //Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene()
    {
        //this.audioSource.PlayOneShot(this.quitClickSound);
    
        SceneManager.LoadScene(sceneName: "HomePage");
    }
} 
