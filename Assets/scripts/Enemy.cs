using JetBrains.Annotations;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]

    private string enemyTolook = "Player";

    [SerializeField]

    private float speed = 1F;
    private Transform objective;

    private Health health;

    private void Start()
    {
        objective = GameObject.FindGameObjectWithTag(enemyTolook).transform;
    }

    private void Update()
    {
        FollowObjetive();
    }

    private void FollowObjetive()
    {
        Vector3 direction = (objective.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health.TakeDamage(1);
        }
    }
        public void Die()
        {
            Destroy(gameObject);
        }
}

