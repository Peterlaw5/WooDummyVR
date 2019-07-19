using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartHittable : MonoBehaviour
{
    public AudioSource hit;
    public AudioSource fail;

    private void OnTriggerEnter(Collider other)
    {
        if ((GetComponent<Renderer>().material.color == Color.blue && other.gameObject.tag == "Lglove") || (GetComponent<Renderer>().material.color == Color.green && other.gameObject.tag == "Rglove"))
        {
            hit.Play();
            ++ScoreManager.score;
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            fail.Play();
        }
    }


}
