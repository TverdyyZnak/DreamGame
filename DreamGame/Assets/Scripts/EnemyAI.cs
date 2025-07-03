using UnityEngine;
using UnityEngine.AI;
using Global.Function;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] private State startingState;
    [SerializeField] private float roamingDistanceMax = 3f;
    [SerializeField] private float roamingDistanceMin = 1f;
    private float roamingTime = 4f;

    private NavMeshAgent agent;
    private State state;
    private float roamingTimeNow;
    private Vector3 roamingPosition;
    private Vector3 roamingStartPosition;
    private enum State 
    {
        Idle,
        Roaming
    }

    private void Start()
    {
        roamingStartPosition = transform.position;
    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; //Чтоб не вращался
        agent.updateUpAxis = false;
        state = startingState;
    }

    private void Update()
    {
        switch (state) 
        {
            case State.Roaming:
                roamingTimeNow -= Time.deltaTime;
                if(roamingTimeNow < 0) 
                {
                    Roaming();
                    roamingTimeNow = Random.Range(roamingTime, 10f);
                }

                break;
            default:
            case State.Idle:
                break;
        }
    }

    private void Roaming() 
    {
        //roamingStartPosition = transform.position;
        roamingPosition = GetRoamingPosition();
        agent.SetDestination(roamingPosition);
    }

    private Vector3 GetRoamingPosition() 
    {
        return roamingStartPosition + GlobalUtils.GetRandomDir() * UnityEngine.Random.Range(roamingDistanceMin, roamingDistanceMax);
    }

}
