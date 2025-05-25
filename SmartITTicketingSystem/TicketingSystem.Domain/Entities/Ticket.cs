using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TicketingSystem.Domain.Enums;

namespace TicketingSystem.Domain.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public TicketPriority Priority { get; set; }
        public TicketStatus Status { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? AssignedTo { get; set; }

      

        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }

    }
}
