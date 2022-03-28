using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    [SerializeField] LayerMask jumpableLayers;
    Jumping jumpState = new Jumping();
    Grounded grounded = new Grounded();
    Falling falling = new Falling();

    public StateMachine CharacterState { get; private set; } = new StateMachine();

    public bool IsGrounded => CharacterState.Current == grounded;

    private void Start() {
        CharacterState.Add(jumpState);
        CharacterState.Add(grounded);
        CharacterState.Add(falling);
    }

    private void OnCollisionEnter(Collision collision) {
        if(jumpableLayers == (jumpableLayers | (1 << collision.gameObject.layer))) {
            CharacterState.ChangeState(grounded);
        }
    }
}
