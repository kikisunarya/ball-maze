using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class maze_transform_left : MonoBehaviour
{
    [SerializeField]
     public Transform maze_transform;

    [SerializeField]
    public float direction;
    public void RotateRight()
    {
        direction = -1;
    }

    public void RotateLeft()
    {
        direction = 1;
    }

    public void ResetRotation()
    {
        direction = 0;
    }
    public void Update()
    {
        maze_transform.Rotate(0,0, direction * 100 * Time.deltaTime);
    }
    // Function to rotate the maze to the left (anti-clockwise)
    public void ClickKanan()
    {
        Debug.Log("Kanan");

        maze_transform.Rotate(0, 0, -10);

Debug.Log(maze_transform.position);
    }
        public void ClickKiri()
    {
        Debug.Log("Kiri");

        maze_transform.Rotate(0, 0, 10);

Debug.Log(maze_transform.position);
    }
}
