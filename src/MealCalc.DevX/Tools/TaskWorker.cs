using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc.DevX
{
  public interface IWorker
  {
    void SetIsWorking(bool working);
  }

  public static class WorkerExtensions
  {
    private class DisposableWorker : IDisposable
    {
      private IWorker worker;

      public DisposableWorker(IWorker worker)
      {
        this.worker = worker;
        worker.SetIsWorking(true);
      }

      public void Dispose()
      {
        if (worker != null)
        {
          worker.SetIsWorking(false);
          worker = null;
        }
      }
    }

    public static IDisposable BeginWork(this IWorker worker)
    {
      return new DisposableWorker(worker);
    }
  }
}
