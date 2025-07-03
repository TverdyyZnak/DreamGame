using UnityEngine;
using System;
public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack Instance { get; private set;}
    private InputSystem_Actions inputAttack;
    public event EventHandler OnAttack; 
    private void Awake()
    {
        Instance = this;
        inputAttack = new InputSystem_Actions();
        inputAttack.Enable();

        inputAttack.Player.Attack.started += Attack_started;
    }

    private void Attack_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnAttack?.Invoke(this, EventArgs.Empty);
    }
}
