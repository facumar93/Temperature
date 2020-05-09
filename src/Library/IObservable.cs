using System;
using System.Collections.Generic;
namespace Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void Unsubscribe(IObserver observer);
        Temperature Current { get; }

        

    }
}