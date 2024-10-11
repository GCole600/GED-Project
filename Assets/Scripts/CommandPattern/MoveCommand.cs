using UnityEngine;

namespace CommandPattern
{
    public class MoveCommand : ICommand
    {
        private PlayerReceiver _player;
        
        public MoveCommand(PlayerReceiver player)
        {
            _player = player;
        }
    
        public void Execute(Vector2 direction)
        {
            _player.Move(direction);
        }
    }
}