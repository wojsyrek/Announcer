using System.Collections.ObjectModel;
using AnnouncerCore.Models.Manager;

namespace AnnouncerCore.Models.Home
{
    public class QueueModel
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public SystemModel System { get; set; }
        public Guid SystemId { get; set; }
    }
}
