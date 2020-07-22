using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    private void OnGUI()
    {
        GUI.Label(new Rect(20,20, 1000, 300), "Score : " + score);
    }
}
