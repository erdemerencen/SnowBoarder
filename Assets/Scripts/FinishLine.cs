using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   [SerializeField] float Reload_delay = 2f;
   [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player"){
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",Reload_delay);
            

}
   }

   void ReloadScene(){
    SceneManager.LoadScene(0);

   }
}
