using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaque_Pression : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Lourd")
        {
            _obstacle.SetActive(false);
        }
        
    }

    private void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject.tag == "Lourd")
        {
            _obstacle.SetActive(true);
        }
    }
}
