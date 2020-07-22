using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject redObstacle;
    public GameObject blueObstacle;
    public GameObject greenObstacle;
    public Vector3 leftStartPos = new Vector3(60, 0.05F, -0.838F);
    public Vector3 midStartPos = new Vector3(60, 0.05F, 0.02F);
    public Vector3 rightStartPos = new Vector3(60, 0.05F, 0.907F);
    void Start()
    { 
        CreateRedObs(5);
        CreateGreenObs(5);
        CreateBlueObs(5);
    }
    private void CreateRedObs(int obstacleNum)
    {
        for (int i=0; i<obstacleNum; i++)
        {
            GameObject temp = Instantiate(redObstacle, new Vector3(leftStartPos.x+i, leftStartPos.y, leftStartPos.z), Quaternion.identity);
        }
    }
    private void CreateBlueObs(int obstacleNum)
    {
        for (int i=0; i<obstacleNum; i++)
        {
            GameObject temp = Instantiate(blueObstacle, new Vector3(midStartPos.x+i, midStartPos.y, midStartPos.z), Quaternion.identity);
        }
    }
     private void CreateGreenObs(int obstacleNum)
    {
        for (int i=0; i<obstacleNum; i++)
        {
            GameObject temp = Instantiate(greenObstacle, new Vector3(rightStartPos.x+i, rightStartPos.y, rightStartPos.z), Quaternion.identity);
        }
    }
     public static Vector3 ChangeX(Vector3 v)
     {
        return new Vector3(v.x+0.3F, v.y, v.z);
     }
     public static Vector3 ChangeY(Vector3 v, float y)
     {
        return new Vector3(v.x, v.y+0.3F, v.z);
     }
     public static Vector3 ChangeZ(Vector3 v, float z)
     {
        return new Vector3(v.x, v.y, v.z+0.3F);
     }
}
