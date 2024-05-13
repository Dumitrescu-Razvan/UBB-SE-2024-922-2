﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessionalProfile.Domain
{
    public class Notification
    {
        [Key]
        public int notificationId { get; set;}
        public int userId { get; set; }
        public string activity { get; set; }
        public DateTime timestamp { get; set; }
        public string details { get; set; }
        public bool isRead { get; set; }

        // Navigation properties
        public User User { get; set; }
    }
}
