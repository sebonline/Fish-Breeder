using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Patrol")]
public class PatrolAction : Action
{
    public override void Act(GameObject target)
    {
        Patrol(target);
    }

    private void Patrol(GameObject target)
    {
        Debug.Log("i am Patrolling");
    }
}