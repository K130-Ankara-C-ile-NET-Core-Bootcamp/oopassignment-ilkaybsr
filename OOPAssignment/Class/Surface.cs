using OOPAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Class
{
    public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
    {
        private long _width;
        private long _height;

        public long Width => _width;

        public long Height => _height;

        public List<CarInfo> GetObservables()
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            throw new NotImplementedException();
        }

        public void Update(CarInfo provider)
        {
            throw new NotImplementedException();
        }

        private List<CarInfo> ObservableCars { get; }

        public Surface(long width, long height)
        {
            _width = width;
            _height = height;
        }

    }
}
