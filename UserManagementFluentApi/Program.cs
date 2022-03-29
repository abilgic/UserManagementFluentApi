
using UserManagementFluentApi.Entities;
using UserManagementFluentApi.Models;
//List<UserRole> userRole = new List<UserRole>
//{
//    new UserRole{RoleName = "Admin"}
//};

//var userPasswords = new List<UserPassword> {
//    new UserPassword
//    {
//        Password1 = "P@ssword1",
//        Password2 = "P@ssword2",
//        Password3 = "P@ssword3"
//    }
//};
//var userCard = new UserIdentityCard
//{
//    Name = "Card1"
//};
var user = new User
{
    FirstName = "John",
    LastName = "Doe",
    BirthDate = DateTime.Now,
    Age = 30,
    Gender = "Male",
    BirthPlace = "Italy",
    City = "Rome",
    Town = "Rome",
    Roles = new List<UserRole>
    {
        new UserRole{RoleName = "Admin"}
    }//,
    //UserPasswords = new List<UserPassword> {
    //new UserPassword
    //{
    //    Password1 = "P@ssword1",
    //    Password2 = "P@ssword2",
    //    Password3 = "P@ssword3"
    //}
    //},
    //UserIdentityCard = new UserIdentityCard
    //{
    //    Name = "Card1"
    //}
};


try
{

    using (var db = new ApplicationDbContext())
    {
        db.Users.Add(user);

        var result = db.SaveChanges();
        //Console.WriteLine($"Result:{result}");
        //var userId = 1;
        //User usr = db.Users.FirstOrDefault(a => a.UserId == userId);//Lazy loading
        ////Relational Table
        //var userrole = usr.Roles.FirstOrDefault(u => u.Id == 1);

        ///Eager Loading
        var users = db.Users.i;

    }
}
catch (Exception e)
{
    Console.WriteLine("Exception:" + e.ToString());
}



