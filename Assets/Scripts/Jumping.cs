using UnityEngine;

public class Jumping : MonoState {
    public override void Enter() {
        base.Enter();
        Debug.Log("Entering Falling Force");
    }

    public override void Exit() {
        base.Exit();
        Debug.Log("Exiting Falling FORCE");
    }
}
