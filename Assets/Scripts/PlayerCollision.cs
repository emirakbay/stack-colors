using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Colors color;
    public Stack<GameObject> colorStack;
    [Header("STACK POSITION VALUES")]
    public Vector3 stackStartPos;
    public Vector3 offSet;
    private GameObject ground;
    public PlayerMovement movement;
    void Start()
    {
        colorStack = new Stack<GameObject>();
    }

    // Pick leftoffs
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (other.gameObject.GetComponent<Obstacle>().color == color)
            {
                other.transform.SetParent(transform);
                colorStack.Push(other.gameObject);
                other.gameObject.GetComponent<Obstacle>().Animate(stackStartPos + offSet * colorStack.Count);
            }
            else
            {
                ground = GameObject.Find("Ground");
                var friction = ground.GetComponent<Collider>();
                friction.material.dynamicFriction = 0.05F;
                friction.material.staticFriction = 0.05F;
                if (colorStack.Count == 0)
                {
                    movement.enabled = false;
                    FindObjectOfType<GameManager>().EndGame();    
                    Debug.Log("Out of stacks except player itself!!!");
                }
                else 
                {
                    var tempObj2 = colorStack.Pop();
                    Destroy(tempObj2);
                }
            }
        }
    }

    public void SetColor(Colors toSet)
    {
        Renderer render = GetComponent<Renderer>();
        color = toSet;
        switch (color)
        {
            case Colors.Green:
                render.material.color = Color.green;
                SetStackColor(Color.green);
                break;
            case Colors.Blue:
                render.material.color = Color.blue;
                SetStackColor(Color.blue);
                break;
            case Colors.Red:
                render.material.color = Color.red;
                SetStackColor(Color.red);
                break;
        }
    }

    private void SetStackColor(Color color)
    {
        foreach(GameObject gameObject in colorStack)
        {
            gameObject.GetComponent<Renderer>().material.color = color;
        }
    }
}

