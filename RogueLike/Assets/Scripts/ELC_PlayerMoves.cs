using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ELC_PlayerMoves : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public bool canMove;

    private Vector3 playerMoves;

    void Update()
    {
        if (canMove)
        {
            Moves();
        }

        Raycasts();
    }

    void Moves()
    {
        playerMoves.x = Input.GetAxis("Horizontal") * speed;
        playerMoves.y = Input.GetAxis("Vertical") * speed;
        playerMoves = Vector3.ClampMagnitude(playerMoves, speed);
        transform.Translate(playerMoves * Time.deltaTime);
    }

    void Raycasts()
    {
        Debug.DrawRay(this.transform.position, transform.TransformDirection(playerMoves), Color.green);
    }
}
