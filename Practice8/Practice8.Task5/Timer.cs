using System;
using System.Threading;

namespace Practice8.Task5
{
  public class Timer
  {
    private readonly int _interval;
    private TimerCallback _callback;
    private System.Threading.Timer _timer;

    public event EventHandler Tick;

    public Timer(int interval)
    {
      this._interval = interval;
    }

    public void Start()
    {
      if (this._timer == null)
      {
        this._callback = new TimerCallback(OnTick);
        this._timer = new System.Threading.Timer(_callback, null, 0, _interval);
      }
    }

    public void Stop()
    {
      this._timer?.Dispose();
      this._timer = null;
    }

    private void OnTick(object state)
    {
      Tick?.Invoke(this, EventArgs.Empty);
    }
  }
}
