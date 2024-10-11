using UnityEngine;

namespace CommandPattern
{
    public class LookCommand : ICommand
    {
        private PlayerReceiver _player;
        private float _sensitivity = 1.0f;

        public LookCommand(PlayerReceiver player)
        {
            _player = player;
        }
        
        public void Execute(Vector2 lookInput)
        {
            _player.Look(lookInput * _sensitivity);
        }
    }
}
