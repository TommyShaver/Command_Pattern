using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
            Movecommand moveUp = new Movecommand(transform, Vector2.up);
            moveUp.Execute();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Movecommand moveDown = new Movecommand(transform, Vector2.down);
            moveDown.Execute();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
           Movecommand moveLeft = new Movecommand(transform, Vector2.left);
            moveLeft.Execute();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           Movecommand moveRight = new Movecommand (transform, Vector2.right);
           moveRight.Execute();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CommandManager.Instance.UndoLastCommand();
        }
             
    }
}
