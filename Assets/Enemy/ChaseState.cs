using UnityEngine;

public class ChaseState :  BaseState
{
    public void EnterState(Enemy enemy)
    {
        Debug.Log("Start Chase");
    }

    public void UpdateState(Enemy enemy)
    {
        Debug.Log("Chasing");
    }

    public void ExitState(Enemy enemy)
    {
        Debug.Log("Stop Chase");
    }
}
