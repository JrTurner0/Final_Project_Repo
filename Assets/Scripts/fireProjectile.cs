using Unity.Hierarchy;
using Unity.VisualScripting;
using UnityEngine;

public class fireProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float speed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject p = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            p.GetComponent<Rigidbody>().linearVelocity = firePoint.forward * speed;
            
        }
    }
}
