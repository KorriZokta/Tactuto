﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargetState : BattleState {
    List<Tile> tiles;
    public override void Enter()
    {
        base.Enter();
        Movement mover = owner.turn.actor.GetComponent<Movement>();
        tiles = mover.GetTilesInRange(board);
        board.SelectTiles(tiles);
    }
    public override void Exit()
    {
        base.Exit();
        board.DeselectTiles(tiles);
        tiles = null;
    }
    protected override void OnMove(object sender, InfoEventArgs<Point> e)
    {
        SelectTile(e.info + pos);
    }
    protected override void OnFire(object sender, InfoEventArgs<int> e)
    {
        if (tiles.Contains(owner.currentTile))
            owner.ChangeState<MoveSequenceState>();
    }
}
