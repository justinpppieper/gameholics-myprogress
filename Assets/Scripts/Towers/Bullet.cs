using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 5.0f;
    public int damage = 20;
    public float slowPercent = 0.3f;

    public void LocateTarget (Transform _target) {
        target = _target;
    }

    void Update() {
        if (target == null) {
            Destroy(gameObject);
            return;
        }

        Vector2 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        // to make sure we can touch the target in this frame
        // direction.magnitude -> the length of direction vector
        if ( direction.magnitude <= distanceThisFrame) {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget() {
        Destroy(gameObject);
        target.GetComponent<Minion>().TakeDamage(damage);
        target.GetComponent<Minion>().SlowDown(slowPercent);

    }
}
