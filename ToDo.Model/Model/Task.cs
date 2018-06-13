﻿using System;

namespace ToDo.Model.Model
{
    public class Task
    {
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityState Priority { get; set; }
    }

    public enum PriorityState
    {
        Low,
        Normal,
        High
    }
}
