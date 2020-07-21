using UnityEngine;

public class Ground : MonoBehaviour
{
   public Collider coll;
    public Colors color;
    private void Start() {
        coll.material.dynamicFriction = 1;
        coll.material.staticFriction = 1;
    }

}
