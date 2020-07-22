using UnityEngine;

public class ColorChanger: MonoBehaviour
{
    public Colors colors;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerCollision>().SetColor(colors);
        }
    }
}
