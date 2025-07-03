using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        PlayerAttack.Instance.OnAttack += Instance_OnAttack;
    }

    private void Instance_OnAttack(object sender, EventArgs e)
    {
        ShovelAttack.Instance.Attack();
    }
}
