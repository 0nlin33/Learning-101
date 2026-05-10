using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float roatationSpeed;
    public GameObject onCollectEffect;
    private Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null) Debug.LogWarning("PlayerController needs a Rigidbody.");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, roatationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy the collectible
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        
        
    }
}
