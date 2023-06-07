using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    [SerializeField] float Reload_delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Ground"){
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
        Invoke("ReloadScene",Reload_delay);
        }
    }
    void ReloadScene(){
    SceneManager.LoadScene(0);  

   }
}