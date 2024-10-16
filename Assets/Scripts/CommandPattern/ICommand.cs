using UnityEngine;

namespace CommandPattern
{
    public interface ICommand
    {
        void Execute(Vector2 direction);
    }
}