using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    //This is the field of view that the Camera has
    float m_FieldOfView;
    void Start()
    {
        //Start the Camera field of view at 60
        m_FieldOfView = 60.0f;
    }
    void Update()
    {
        transform.position = player.position + offset;
        //Update the camera's field of view to be the variable returning from the Slider
        Camera.main.fieldOfView = m_FieldOfView += 0.01f;
    }
}
