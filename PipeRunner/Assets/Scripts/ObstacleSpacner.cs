using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpacner : MonoBehaviour
{

    public Transform Player;
    public Transform ObstaclePrefab;
    public Transform LatestObstacle = null;
    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            if (LatestObstacle == null)
            {
                int Rotation = Random.Range(0, 359);
                var Obstacle = Instantiate(ObstaclePrefab, new Vector3(Player.transform.position.x, Player.transform.position.y - 5, Player.transform.position.z - 10), new Quaternion(90, Rotation, 0, 0));
                LatestObstacle = Obstacle;
            }
            else {
                int Rotation = Random.Range(0, 359);
                var Obstacle = Instantiate(ObstaclePrefab, new Vector3(LatestObstacle.transform.position.x, LatestObstacle.transform.position.y, LatestObstacle.transform.position.z - 10), new Quaternion(90, Rotation, 0, 0));
                LatestObstacle = Obstacle;
            }
            
        }
        
    }
    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("obstacle").Length != 20) {
            int Rotation = Random.Range(0, 360);
            var Obstacle = Instantiate(ObstaclePrefab, new Vector3(LatestObstacle.transform.position.x, LatestObstacle.transform.position.y , LatestObstacle.transform.position.z - 50), new Quaternion(90, Rotation, 0, 0));
            LatestObstacle = Obstacle;

        }
        
    }


   

}
