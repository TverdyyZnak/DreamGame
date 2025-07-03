using UnityEngine;

public class Following : MonoBehaviour
{
    //[SerializeField] private GameObject _player;
    [SerializeField] private float _speed = 4f;
    private Rigidbody2D _mainObject;
    private Transform _transformHero;
    private void Start()
    {
        _transformHero = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _mainObject = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Vector2 mainVector = (_transformHero.position - transform.position);
        _mainObject.MovePosition(_mainObject.position + mainVector.normalized * (_speed * Time.fixedDeltaTime));
    }
}
