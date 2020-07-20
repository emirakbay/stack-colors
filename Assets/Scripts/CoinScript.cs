using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(90*Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().score++;
            Destroy(gameObject);
        }
    }
}