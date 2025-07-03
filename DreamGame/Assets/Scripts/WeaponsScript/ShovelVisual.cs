using UnityEngine;

public class ShovelVisual : MonoBehaviour
{
    [SerializeField] private ShovelAttack shovelAttack;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        shovelAttack.OnAttack += ShovelAttack_OnAttack;
    }

    private void ShovelAttack_OnAttack(object sender, System.EventArgs e)
    {
        for (int i = 0; i < 1; i++)
        {
            _animator.SetTrigger("Attack");
        }
        
    }
}
