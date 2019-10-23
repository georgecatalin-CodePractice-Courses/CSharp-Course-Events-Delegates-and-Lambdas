﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class WorkPerformedEventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            this.Hours = hours;
            this.WorkType = workType;
        }

    }
}
