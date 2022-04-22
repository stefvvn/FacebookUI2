using Facebook.Data.EntityFramework;
using Facebook.Entities;

Console.WriteLine("Prvi user");
AccountUserInfoEF EF = new AccountUserInfoEF();
AccountUserInfoEntities user = EF.GetUserByID(1);
Console.WriteLine(user.UserName);
Console.WriteLine(user.FirstName);
Console.WriteLine(user.City);
Console.WriteLine(user.LastName);
Console.WriteLine(user.GenderString);
Console.WriteLine(user.ProfileDescription);
Console.WriteLine(user.DateOfBirth.ToString());
Console.WriteLine(user.DateMade.ToString());
Console.WriteLine(user.EmailAddress);