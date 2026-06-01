using System;

namespace WorkProgressManagement.Models
{
    public class WorkTask
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Deadline { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}