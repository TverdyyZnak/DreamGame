using System;
using UnityEngine;

public class ShovelAttack : MonoBehaviour
{
    public event EventHandler OnAttack;

    public static ShovelAttack Instance {  get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public void Attack() 
    {
        OnAttack?.Invoke(this, EventArgs.Empty);
    }
}
