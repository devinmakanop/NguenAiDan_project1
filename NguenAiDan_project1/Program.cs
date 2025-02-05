﻿// See https://aka.ms/new-console-template for more information

using NguenAiDan_project1;

using (var context = new SchoolContext())
{
    //creates db if not exists 
    context.Database.EnsureCreated();

   
    context.SaveChanges();

    //retrieve all the students from the database
    foreach (var s in context.Students)
    {
        Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
    }
}
