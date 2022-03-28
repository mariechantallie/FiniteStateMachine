using System;
using UnityEngine;

public class Falling : MonoState {
    public override void Enter() {
        base.Enter();
        Debug.Log("Entering Falling Force");
    }

    public override void Exit() {
        base.Exit();
        Debug.Log("Exiting Falling FORCE");
    }
}
