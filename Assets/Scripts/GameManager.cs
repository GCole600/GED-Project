using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        public bool GotKeyCard { get; set; }
    }
}