using UnityEngine;
using System.Collections;

public class SphereSoundCollision : MonoBehaviour {

    //    Volume: 0..1
    //      Magnitude
    void OnCollisionStay(Collision col)
    {
       // if (!GetComponent<AudioSource>().isPlaying && col.relativeVelocity.magnitude >= 2) { 
       // GetComponent<AudioSource>().volume = col.relativeVelocity.magnitude / 20;
        GetComponent<AudioSource>().Play();

            // Debug.Log(col.relativeVelocity.magnitude);
       // }
    }
    
}
