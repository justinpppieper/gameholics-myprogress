using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Minion))]
public class MinionMovement : MonoBehaviour
{
    private Minion minion;
    private Transform target;
    private int wayPointIndex = 0;

    void Start()
    {
        minion = GetComponent<Minion>();
        target = WayPoints.wayPoints[0];
    }

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * minion.speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {

        if (wayPointIndex >= WayPoints.wayPoints.Length - 1)
        {
            ArriveDestination();
            return;
        }

        wayPointIndex++;
        target = WayPoints.wayPoints[wayPointIndex];
    }

    void ArriveDestination() {
        PlayerStatus.lives --; // reference to PlayerStatus, GameStatus
        Destroy(gameObject);
    }
}
