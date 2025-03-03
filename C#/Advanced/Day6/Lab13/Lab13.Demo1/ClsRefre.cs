﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Demo1
{
    internal class ClsRefre : ClsPerson
    {
        private int _speed = 2;
        public int Speed
        {
            get => _speed;
            init
            {
                if (value > 0)
                    _speed = value;
                else Console.WriteLine($"Refer {Name} , Speed set to : {Speed}");
            }
        }
        public ClsPoint Position { get; private set; } = new ClsPoint();

        public ClsRefre(int id, string name, ClsPoint position, int speed = 2)
        {
            Id = id;
            Name = name;
            Position = position;
            Speed = speed;
        }

        void FollowBall(ClsBall b)
        {
            if (Position.X < b.Position.X)
                //if the Refer move with his speed will be after the ball position he will decrease his speed to get exactly where the ball is.
                Position.X = (Position.X + Speed > b.Position.X) ? b.Position.X : Position.X + Speed;
            else Position.X = (Position.X - Speed < b.Position.X) ? b.Position.X : Position.X - Speed;

            if (Position.Y < b.Position.Y)
                Position.Y = (Position.Y + Speed > b.Position.Y) ? b.Position.Y : Position.Y + Speed;
            else Position.Y = (Position.Y - Speed < b.Position.Y) ? b.Position.Y : Position.Y - Speed;
            Console.WriteLine(this);
        }
        public void ReferIn(ClsBall b) => b.RegisterEvBallMove(FollowBall);
        public override string ToString() => $"{"Refer",-6}: {Id} , Name : {Name,-6} , Position {Position} , Speed : {Speed}";
    }
}
