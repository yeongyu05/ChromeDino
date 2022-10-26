using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float StartMoveSpeed = 3f;
    [SerializeField]
    private float SpeedUp = 0.0001f;

    private float MoveSpeed;

    // Update is called once per frame
    void Update()
    {
        MoveSpeed += SpeedUp * Time.deltaTime;
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
    }
}
