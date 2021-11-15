using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject rocks;
    int score = 0;
    GUIStyle guiStyle = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }
    void CreateObstacle()
    {
        Instantiate(rocks);
    }
    // Update is called once per frame
    void Update()
    {
        score++;
    }
    private void OnGUI()
    {
        GUI.color = Color.black;
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(0, 0, 300, 50), "Score" + score.ToString(), guiStyle);
    }
}