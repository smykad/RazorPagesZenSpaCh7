﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class ClientService
    {
        [Key]
        public int ID { get; set; }
        
        [ForeignKey("ClientID")]
        public int ClientID { get; set; }
        public Client Client { get; set; }
        
        [ForeignKey("ServicesID")]
        public int ServicesID { get; set; }
        public Services Services { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
