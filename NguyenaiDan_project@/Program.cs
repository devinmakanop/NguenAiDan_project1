// See https://aka.ms/new-console-template for more information

using NguyenaiDan_project2;

using (var context = new SchoolContext())
{
 
    //creates db if not exists 
    context.Database.EnsureCreated();

   
    context.SaveChanges();

}
