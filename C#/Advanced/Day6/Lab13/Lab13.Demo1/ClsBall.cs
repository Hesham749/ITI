using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Demo1
{
    internal class ClsBall
    {

        Action<ClsBall> EvBallMove;
        private int _id;

        public ClsPoint Position { get; private set; } = new ClsPoint();
        public int Id
        {
            get => _id;

            set { if (value > 0) _id = value; }
        }


        public ClsBall(int id, ClsPoint position) : this(id)
        {
            Position = position;
        }

        public ClsBall(int id) => Id = id;

        public void RegisterEvBallMove(Action<ClsBall> EventHandler) => EvBallMove += EventHandler;
        public void UnRegisterEvBallMove(Action<ClsBall> EventHandler) => EvBallMove -= EventHandler;

        public void MoveBall(int x, int y)
        {
            Position.X += x;
            Position.Y += y;
            EvBallMove?.Invoke(this);
        }

        public void BallOut() => EvBallMove = null;
        public override string ToString() => $"{"Ball",-6}: {Id} , Position : {Position}";
    }
}
