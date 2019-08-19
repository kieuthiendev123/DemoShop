﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DemoShop.Data.Enums;
using DemoShop.Data.Interfaces;
using DemoShop.Infrastructure.SharedKernel;

namespace DemoShop.Data.Entities
{
    [Table("Pages")]
    public class Page : DomainEntity<int>,ISwitchable
    {
        public Page() { }

        public Page(int id, string name, string alias, 
            string content, Status status)
        {
            Id = id;
            Name = name;
            Alias = alias;
            Content = content;
            Status = status;
        }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public Status Status { set; get; }
    }
}
