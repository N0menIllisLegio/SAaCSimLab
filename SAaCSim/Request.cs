namespace SAaCSim
{
    enum RequestState
    {
        Discarded,
        Processing,
        Pending,
        Completed,
    }

    class Request
    {
        public RequestState State;
        public int ExistingTime;
        public int CreationTact;

        public void TicksPassed(int ticks = 1)
        {
            if (State == RequestState.Processing || State == RequestState.Pending)
            {
                ExistingTime = ExistingTime + ticks;
            }
        }
    }
}
