using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public float damage = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary") return;

        if (other.tag == "Enemy")
        {
            PriestHealth enemy = (PriestHealth)other.gameObject.GetComponent<PriestHealth>();
            if (enemy != null) enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}