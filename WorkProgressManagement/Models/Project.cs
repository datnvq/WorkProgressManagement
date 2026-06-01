using System;
using System.Collections.Generic;

namespace WorkProgressManagement.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<WorkTask> WorkTasks { get; set; }

        public Project()
        {
            CreatedAt = DateTime.Now;
            WorkTasks = new List<WorkTask>();
        }
    }
}