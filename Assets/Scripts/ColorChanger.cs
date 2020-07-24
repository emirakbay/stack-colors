using UnityEngine;

public class ColorChanger: MonoBehaviour
{
    public Colors colors;
    void Start()
    {
        SetColor(colors);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerCollision>().SetColor(colors);
        }
    }
    private void SetColor(Colors toSet)
    {
        Renderer render = GetComponent<Renderer>();
        colors = toSet;
        switch (colors)
        {
            case Colors.Green:
                render.material.color = Color.green;
                break;
            case Colors.Blue:
                render.material.color = Color.blue;
                break;
            case Colors.Red:
                render.material.color = Color.red;
                break;
        }
    }
}
