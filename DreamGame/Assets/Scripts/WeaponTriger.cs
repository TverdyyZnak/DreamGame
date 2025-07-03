using UnityEngine;

public class WeaponTriger : MonoBehaviour
{
    private bool isCollidingWithEnemy = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Enemy"))
        {
            isCollidingWithEnemy = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Enemy"))
        {
            isCollidingWithEnemy = false;
        }
    }

    private void Update()
    {
        if (isCollidingWithEnemy && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("¬раг в зоне");
        }
    }
}
