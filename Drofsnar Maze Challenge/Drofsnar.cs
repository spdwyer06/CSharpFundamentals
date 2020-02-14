using System;
using System.Collections.Generic;
using System.Text;

namespace Drofsnar_Maze_Challenge
{
    public class Drofsnar
    {
        private int _health = 4;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        private int _points = 5000; 
        public int Points 
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }
    }
}
