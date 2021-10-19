using OOPAssignment.Interfaces;
using System;

namespace OOPAssignment.Class
{
    public class Car : ICarCommand, Interfaces.IObservable<CarInfo>
    {
        Guid Id;
        public Coordinates Coordinates;
        public Direction Direction;
        public ISurface Surface;

        private Interfaces.IObserver<CarInfo> Observer { get; set; }

        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
        }

        public void Attach(Interfaces.IObserver<CarInfo> observer)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void TurnLeft()
        {
            throw new NotImplementedException();
        }

        public void TurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
