﻿using System;
using CodingEvents.Models;
using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEvents.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; } //primary key
        public DbSet<EventCategory> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options)
              : base(options)
        {
        }


    }
}
