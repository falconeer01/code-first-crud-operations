using DatabaseExample;
using DatabaseExample.Entities;
using DatabaseExample.Repositories.Concretes;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// Include işlemi:
PersonalRepository personalRepository = new();
//Console.WriteLine(JsonConvert.SerializeObject(
//    personalRepository.GetAll(include: personal => personal.Include(p => p.User))
//));

// Order by işlemi:
Console.WriteLine(JsonConvert.SerializeObject(
    personalRepository.GetAll(
        orderBy: personal => 
            personal.OrderBy(p => p.Salary)
            .ThenBy(p => p.User.UserName)
    ).ToList()
));

/* User ve Personal ekleme:
UserRepository userRepository = new();
var usersJson = File.ReadAllText("C:\\Users\\omrcn\\source\\repos\\soft-ito-backend\\DatabaseExample\\DummyData\\users.json");
var users = JsonConvert.DeserializeObject<List<User>>(usersJson);
users.ForEach(user =>
{
    userRepository.Add(user);
});
var userArray = userRepository.GetAll().ToArray();


PersonalRepository personalRepository = new();
var personalsJson = File.ReadAllText("C:\\Users\\omrcn\\source\\repos\\soft-ito-backend\\DatabaseExample\\DummyData\\personals.json");
var personals = JsonConvert.DeserializeObject<List<Personal>>(personalsJson);
if (userArray == null) return;
int index = 0;
personals.ForEach(personal =>
{
    personal.UserId = userArray[index].Id;
    personalRepository.Add(personal);
    index++;
});
/*

//User newUser = new()
//{
//    FirstName = "Ali",
//    LastName = "Veli",
//    IdentificationNumber = "5ASF6G2",
//    UserName = "aliveli",
//    Password = "fisşpakfeq75eq4te4qw68te",
//    IsActive = true
//};

//userRepository.Add(newUser);

/*
UserRepository userRepository = new();
var user = userRepository.Get(user => user.FirstName.StartsWith("a"));
Console.WriteLine(JsonConvert.SerializeObject(user));
/*

/*
db.Users.Add(new DatabaseExample.Entities.User()
{
    FirstName = "Yakup",
    LastName = "Eyisan",
    UserName = "yakupeyisan",
    Password = "1234",
    IsActive = true,
    IdentificationNumber="11223344551"
}) ;

db.SaveChanges();
*/

//var user = db.Users.Where(user => user.IdentificationNumber == "11223344551").FirstOrDefault();

//if (user != null)
//{
//    user.Password = "12345";
//    db.Users.Update(user);
//    db.SaveChanges();
//    db.Users.Remove(user);
//    db.SaveChanges();
//}

//var users = db.Users.ToList();

//Console.WriteLine(JsonConvert.SerializeObject(users));
//Console.ReadKey();

/*
IList<User> UserList = JsonConvert.DeserializeObject<IList<User>>(Datas.UserData);

ExampleDbContext db = new();

byte count = 0;

UserList.ToList().ForEach(user =>
{
    User newUser = new User
    {
        UserName = user.UserName,
        FirstName = user.FirstName,
        LastName = user.LastName,
        Password = user.Password,
        IdentificationNumber = user.IdentificationNumber,
        IsActive = user.IsActive,
    };

    db.Users.Add(newUser);

    if (count < 30)
    {
        db.Personals.Add(new Personal
        {
            UserId = newUser.Id,
            Salary = new Random().Next(2000, 10000),
            SSN = "" + new Random().Next(100, 900) + "-" + new Random().Next(100, 900) + "-" + new Random().Next(100, 900),
        });
    }

    else if (count < 60)
    {
        db.Students.Add(new Student
        {
            UserId = newUser.Id,
            Number = "" + new Random().Next(20, 5000),
            Marks = (byte)new Random().Next(0, 100),
            Absenteeism = (byte)new Random().Next(0, 100)
        });
    }

    else if (count < 90)
    {
        db.Jobbers.Add(new Jobber
        {
            UserId = newUser.Id,
            Plate = "" + new Random().Next(100, 900) + "-" + new Random().Next(100, 900),
            WorkArea = "jobber" + count
        });
    }

    else
    {
        db.Personals.Add(new Personal
        {
            UserId = newUser.Id,
            Salary = new Random().Next(2000, 10000),
            SSN = "" + new Random().Next(100, 900) + "-" + new Random().Next(100, 900) + "-" + new Random().Next(100, 900),

        });
        db.Students.Add(new Student
        {
            UserId = newUser.Id,
            Number = "" + new Random().Next(20, 5000),
            Marks = (byte)new Random().Next(0, 100),
            Absenteeism = (byte)new Random().Next(0, 100)
        });
        db.Jobbers.Add(new Jobber
        {
            UserId = newUser.Id,
            Plate = "" + new Random().Next(100, 900) + "-" + new Random().Next(100, 900),
            WorkArea = "jobber" + count
        });
    }
});

db.SaveChanges();
*/