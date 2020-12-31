using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private AudioSource _shootSound;
    private Rigidbody _bulletRb;

    // Start is called before the first frame update
    void Start()
    {
        _bulletRb = GetComponent<Rigidbody>();
        _shootSound.Play();

    }

    // Update is called once per frame
    void Update()
    {
        _bulletRb.AddForce(Vector3.forward * _bulletSpeed);
    }
}
