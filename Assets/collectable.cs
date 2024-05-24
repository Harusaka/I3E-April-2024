using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    int myScore = 5;
    float expirationTime = 5.5f;
    bool collected = false;
    string collectibleName = "Tofu";
    string collectableDescription = "These are some Tofus";

    void Collected()
    {
        Debug.Log("I got collected");
        Destroy(gameObject);
    }

    //this happens when something touches me
    private void OncollisionEnter(Collision collision)
    {
        //check if object thattouched me has the player tag
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            Collected();
        }
    }

    private void OncollisionExit(Collision collision)
    {
        Debug.Log("Something stopped touching me");
    }

    private void OncollisionStay(Collision collision)
    {
        Debug.Log("Something is still touching me");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered the area");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Something left the area");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Something still in the area");
    }


    void Spawn()
    {

    }
}
