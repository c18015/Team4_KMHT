using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lotation : MonoBehaviour
{

    Transform target;
    float speed = 2f;

    void Start()
    {
        target = GameObject.Find("Cube").transform;
    }

    void Update()
    {
        transform.Rotate(0, 4f, 0, Space.Self);
        Vector3 targetDir = target.position - transform.position;
        targetDir.y = transform.position.y; //targetと高さが異なると体ごと上下を向いてしまうので制御
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, -90.0F);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
