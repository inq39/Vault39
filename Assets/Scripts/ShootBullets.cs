using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;   
    [SerializeField] private float _fireRate;
    
    private float _fireRateTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _fireRateTimer += Time.deltaTime;
        ShootWeapon();
    }

    private void ShootWeapon()
    {
        if (Input.GetMouseButtonDown(0) && _fireRateTimer >= _fireRate)
        {
            GameObject bullet = Instantiate(_bulletPrefab, transform.position, transform.parent.rotation); 
            _fireRateTimer = 0;

        }
    }
}
