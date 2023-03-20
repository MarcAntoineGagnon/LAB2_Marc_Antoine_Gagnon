using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege_Teleportation : MonoBehaviour
{
    [SerializeField] private float _positionX = 0f;
    [SerializeField] private float _positionY = 0f;
    [SerializeField] private float _positionZ = 0f;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(_positionX, _positionY, _positionZ);
    }
}
