using System.Runtime.CompilerServices;
using UnityEngine;

public class LessonEvents : MonoBehaviour
{
    private void OnEnable()
    {
        IsEnemyOrNot.onT += eventGole;
    }

    private void OnDisable()
    {
        IsEnemyOrNot.onT -= eventGole;
    }

    private void eventGole()
    {
        Debug.Log("Есть косание");
    }

}
