using System;

public abstract class Activity
    {
        public DateTime date;
        protected int length;

        public Activity(DateTime date, int length)
        {
            this.date = date;
            this.length = length;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public abstract string GetSummary();

        public bool IsMetric()
        {
            return true;
        }
    }
