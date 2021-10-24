using OOPAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPAssignment.Class
{
    public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
    {
        private long _width;
        private long _height;
        public long Width => _width;
        public long Height => _height;
        private readonly List<CarInfo> ObservableCars;

        public Surface(long width, long height)
        {
            _width = width;
            _height = height;

            ObservableCars = new List<CarInfo>();
        }

        public List<CarInfo> GetObservables()
        {
            return new List<CarInfo>(ObservableCars);
        }

        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            if (coordinates.Y > Height || coordinates.Y < 0
                || coordinates.X > Width || coordinates.X < 0)
                return false;

            return true;
        }


        public void Update(CarInfo provider)
        {
            var car = ObservableCars.FirstOrDefault(x => x.CarId == provider.CarId);
            if (car != null)
                car = provider;
            else
                ObservableCars.Add(provider);
        }
    }
}
