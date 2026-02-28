using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    public GameObject onCollectEffect;
    private void Update()
    {
        transform.Rotate(0f, rotationSpeed, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            Debug.Log("Collectible picked up!");
            Destroy(gameObject); 
        }
    }
}
