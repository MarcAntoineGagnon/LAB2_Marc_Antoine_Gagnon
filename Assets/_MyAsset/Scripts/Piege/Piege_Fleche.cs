using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege_Fleche : MonoBehaviour
{
    private GestionCollision _gestionCollision;

    private void OnCollisionEnter(Collision collision)
    {
        // s'il touche le joueur disparait
        if(collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }


}
