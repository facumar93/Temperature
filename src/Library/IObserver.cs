using System;
using System.Collections.Generic;
namespace Observer
{
    public interface IObserver
    {
        void StartReporting(IObservable provider);
        void Update();

    }
}