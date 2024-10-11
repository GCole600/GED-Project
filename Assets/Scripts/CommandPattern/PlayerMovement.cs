using UnityEngine;
using UnityEngine.InputSystem;

namespace CommandPattern
{
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerInput _playerInput;
        private InputAction _moveAction;
        private InputAction _lookAction;
        private MoveCommand _moveCommand;
        private LookCommand _lookCommand;
        private PlayerReceiver _playerReceiver;

        private Vector2 _movementInput;
        private Vector2 _lookInput;

        private void Awake()
        {
            _playerInput = GetComponent<PlayerInput>();
            _playerReceiver = GetComponent<PlayerReceiver>();
        
            _moveCommand = new MoveCommand(_playerReceiver);
            _lookCommand = new LookCommand(_playerReceiver);
        }

        private void OnEnable()
        {
            _moveAction = _playerInput.actions["HorizontalMovement"];
            _lookAction = _playerInput.actions["Look"];
        
            _moveAction.Enable();
            _lookAction.Enable();
        }
    
        private void OnDisable()
        {
            _moveAction.Disable();
            _lookAction.Disable();
        }

        private void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        
            _movementInput = _moveAction.ReadValue<Vector2>();
            _lookInput = _lookAction.ReadValue<Vector2>();
        
            if (_movementInput != Vector2.zero)
                _moveCommand.Execute(_movementInput);
        
            _lookCommand.Execute(_lookInput);
        }
    }
}