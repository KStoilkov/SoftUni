namespace _02.AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {
        public AsyncTimer(Action method, int interval, int ticks)
        {
            this.Method = method;
            this.Interval = interval;
            this.Ticks = ticks;
        }

        public Action Method { get; set; }

        public int Interval { get; set; }

        public int Ticks { get; set; }

        public void Start()
        {
            Thread thread = new Thread(this.SomeMethod);
            thread.Start();
        }

        private void SomeMethod()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);

                this.Method();

                this.Ticks--;
            }
        }
    }
}
