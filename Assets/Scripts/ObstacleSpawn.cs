using UnityEngine;
public class ObstacleSpawn : MonoBehaviour
{
    Collider m_Collider;
    Vector3 m_Center;
    Vector3 m_Size, m_Min, m_Max;
    public GameObject redObstacle;
    public GameObject blueObstacle;
    public GameObject greenObstacle;
    private void Start() 
    {
        //Fetch the Collider from the GameObject
        m_Collider = GetComponent<Collider>();
        m_Max = m_Collider.bounds.max;
        CreateObstacle();
    }
    private void CreateObstacle()
    {
        
        for (int i=5; i<(int)m_Max.x; i++)
        {
            if (i % 5 == 0)
                i += 10;
                
            if (i>(int)m_Max.x)
            {
                break;
            }
            GameObject redObs = Instantiate(redObstacle, new Vector3(i * 1.0F, 0.05F, -0.838F), Quaternion.identity);
            GameObject blueObs = Instantiate(blueObstacle, new Vector3(i * 1.0F, 0.05F, 0.02F), Quaternion.identity);
            GameObject greenObs = Instantiate(greenObstacle, new Vector3(i * 1.0F, 0.05F, 0.907F), Quaternion.identity);
        }
    }
}