using System;
using UnityEngine;


public class IsEnemyOrNot : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    public static Action onT; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == enemy.tag)
        {
            Debug.Log("ַמלבט!!!");
            //onT();
                
        }

    }
}
