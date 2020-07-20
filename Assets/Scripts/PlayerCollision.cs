using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Colors color;
    public Stack<GameObject> colorStack;
    [Header("STACK POSITION VALUES")]
    public Vector3 stackStartPos;
    public Vector3 offSet;

    /*
     
    PhysicMaterial mat;
    
    void Start()
    {
        mat = collider.sharedMaterial;
    }
    void IncreaseFriction ()
    {
        mat.dynamicFriction += 0.1f;
    }

     
    */

    void Start()
    {
        colorStack = new Stack<GameObject>();
    }

    // yavaşlat
    // yerde kalanları topla
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
                if (colorStack.Count == 0)
                {
                    Debug.Log("Out of stacks except player itself!!!");
                }
                else 
                {
                    var tempObj = colorStack.Pop();
                    Destroy(tempObj);
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

