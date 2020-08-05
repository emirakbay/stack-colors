using UnityEngine;
public class ObstacleSpawn : MonoBehaviour
{
    Collider m_Collider;
    Vector3 m_Min, m_Max;
    public GameObject[] obstacles;
    int obstacleNumber;
    public GameObject endTrigger;
    private void Start() 
    {
        //Fetch the Collider from the GameObject
        m_Collider = GetComponent<Collider>();
        m_Max = m_Collider.bounds.max;
        m_Min = m_Collider.bounds.min;
        CreateObstacle();
        obstacleNumber = GameObject.FindGameObjectsWithTag("Obstacle").Length;
        print(obstacleNumber);
    }
    private void CreateObstacle()
    {
        endTrigger = GameObject.Find("END");
        var position = endTrigger.GetComponent<Transform>().position.x;
        for (int i=(int)m_Min.x; i<(int)m_Max.x; i++)
        {
            if (i < 0)
                continue;

            if (i % 5 == 0)
                i += 10;

            if (i>position)
                break;

    
            GameObject redObs = Instantiate(obstacles[0], new Vector3(i * 1.0F, 0.05F, -0.838F), Quaternion.identity);
            GameObject blueObs = Instantiate(obstacles[1], new Vector3(i * 1.0F, 0.05F, 0.02F), Quaternion.identity);
            GameObject greenObs = Instantiate(obstacles[2], new Vector3(i * 1.0F, 0.05F, 0.907F), Quaternion.identity);
        }
    }
}