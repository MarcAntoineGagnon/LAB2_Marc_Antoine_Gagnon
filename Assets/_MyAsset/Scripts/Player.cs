using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attribut
    [SerializeField] private float _speed = 500f;
    private Rigidbody _rb;

    void Start()
    {
        transform.position = new Vector3(-45f, 0.1f, -45f);
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MouvementsPlayer();
    }

    private void MouvementsPlayer()
    {
        float sprint = _speed * 1.5f;
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new(positionX, 0f, positionZ);
        float angle = Mathf.Atan2(positionX, positionZ) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, angle, 0f);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _rb.velocity = direction.normalized * Time.fixedDeltaTime * sprint; // Mouvement sprint
        }
        else
        {
            _rb.velocity = direction.normalized * Time.fixedDeltaTime * _speed; // Mouvement normale
        }
        //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse); // Mouvement (glisse)

        // Rotation Player en fonction de direction du déplacement

    }
}
