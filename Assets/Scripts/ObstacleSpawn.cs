using UnityEngine;
public class ObstacleSpawn : MonoBehaviour
{
    public GameObject redObstacle;
    public GameObject blueObstacle;
    public GameObject greenObstacle;
    private void Start() 
    {
        CreateObstacle();
    }
    private void CreateObstacle()
    {
        for (int i=0; i<150; i++)
        {
            if (i % 5 == 0)
                i += 10;
            GameObject redObs = Instantiate(redObstacle, new Vector3(i * 1.0F, 0.05F, -0.838F), Quaternion.identity);
            GameObject blueObs = Instantiate(blueObstacle, new Vector3(i * 1.0F, 0.05F, 0.02F), Quaternion.identity);
            GameObject greenObs = Instantiate(greenObstacle, new Vector3(i * 1.0F, 0.05F, 0.907F), Quaternion.identity);
        }
    }
}