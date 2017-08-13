﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class SelectUnitState : BattleState {
    protected override void OnMove(object sender, InfoEventArgs<Point> e)
    {
        SelectTile(e.info + pos); 
    }
    protected override void OnFire(object sender, InfoEventArgs<int> e)
    {
        GameObject content = owner.currentTile.content;
        if (content != null)
        {
            owner.turn.actor = content.GetComponent<Unit>();
            owner.ChangeState<MoveTargetState>();
        }
    }
}
*/
  public class SelectUnitState : BattleState
{
    int index = -1;
    public override void Enter()
    {
        base.Enter();
        StartCoroutine("ChangeCurrentUnit");
    }
    IEnumerator ChangeCurrentUnit()
    {
        index = (index + 1) % units.Count;
        turn.Change(units[index]);
        yield return null;
        owner.ChangeState<CommandSelectionState>();
    }
}