using NguyenAiDan_Project3;

using (var context = new SchoolContext())
{

    //creates db if not exists 
    context.Database.EnsureCreated();


    context.SaveChanges();

}
