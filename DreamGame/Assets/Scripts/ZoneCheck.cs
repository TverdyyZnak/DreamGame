using UnityEngine;

public class ZoneCheck : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == player.tag) 
        {
            Debug.Log("�� � ���� ������");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == player.tag)
        {
            Debug.Log("�� �� � ���� ������");
        }
    }
}
