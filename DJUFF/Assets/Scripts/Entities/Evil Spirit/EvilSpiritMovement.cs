using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSpiritMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private EvilSpiritController controller;

    [Header("Variables")]
    [SerializeField] private float speed;

    private Transform goal;

    private void FixedUpdate()
    {
        if (controller.haunting)
            MoveCloser();
    }

    public void SetRandomPos()
    {
        float time = controller.possesionTime;

        float distance = time * speed;

        Vector3 dir = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
        Vector3 pos = goal.position + distance * dir;

        transform.position = pos;
    }

    public void SetGoal(Transform goal)
    {
        this.goal = goal;
    }

    private void MoveCloser()
    {
        Vector3 dir = (goal.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}
