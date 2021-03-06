﻿using ME.dll.Models.BookInventory;
using Microsoft.EntityFrameworkCore;

namespace ME.dll
{
    /*
     * The DbContext class is an integral part of Entity Framework. 
     * An instance of DbContext represents a session with the database which can be used to query and save instances
     * of your entities to a database. 
     * DbContext is a combination of the Unit Of Work and Repository patterns.*/

    public class MEDbContext: DbContext
    {
        public MEDbContext(DbContextOptions<MEDbContext> options): base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }

}