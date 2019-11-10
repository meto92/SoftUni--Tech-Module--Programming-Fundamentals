using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class User
{
    private string name;
    private List<string> comments;
    private List<DateTime> attendancyDates;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<string> Comments
    {
        get { return comments; }
        set { comments = value; }
    }

    public List<DateTime> AttendancyDates
    {
        get { return attendancyDates; }
        set { attendancyDates = value; }
    }

    public User(string name)
    {
        Name = name;
        comments = new List<string>();
        attendancyDates = new List<DateTime>();
    }
}

class MentorGroup
{
    static void Main(string[] args)
    {
        SortedDictionary<string, User> users = new SortedDictionary<string, User>();

        string attendance;

        while ((attendance = Console.ReadLine()) != "end of dates")
        {
            string[] attendanceParams = attendance.Split(' ');

            string usernname = attendanceParams[0];

            if (!users.ContainsKey(usernname))
            {
                users[usernname] = new User(usernname);
            }

            if (attendanceParams.Length > 1)
            {
                DateTime[] dates = attendanceParams[1].Split(',').Select(date => DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToArray();

                users[usernname].AttendancyDates.AddRange(dates);
            }
        }

        string input;

        while ((input = Console.ReadLine()) != "end of comments")
        {
            string[] commentParams = input.Split('-');

            string username = commentParams[0];
            string comment = commentParams[1];

            if (users.ContainsKey(username))
            {
                users[username].Comments.Add(comment);
            }
        }

        foreach (KeyValuePair<string, User> pair in users)
        {
            string user = pair.Key;
            List<string> userComments = pair.Value.Comments;
            List<DateTime> userAttendances = pair.Value.AttendancyDates.OrderBy(date => date).ToList();

            Console.WriteLine(user);
            Console.WriteLine("Comments:");

            for (int i = 0; i < userComments.Count; i++)
            {
                Console.WriteLine($"- {userComments[i]}");
            }

            Console.WriteLine($"Dates attended:");

            for (int i = 0; i < userAttendances.Count; i++)
            {
                DateTime date = userAttendances[i];

                Console.WriteLine($"-- {date.Day:d2}/{date.Month:d2}/{date.Year}");
            }
        }
    }
}