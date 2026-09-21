using System;
using System.Globalization;
using System.Text;

namespace Academy_Schedule_Analyzer
{
    class Program
    {
        // Part 1 - Arrays
        static string[] sessionNames =
        {
            "C# Basics",
            "Arrays and Functions",
            "Reference Types and ref",
            "DateTime and TimeSpan",
            "Exception Handling"
        };

        static DateTime[] sessionDates =
        {
            new DateTime(2026, 9, 10, 18, 0, 0),
            new DateTime(2026, 9, 17, 18, 0, 0),
            new DateTime(2026, 9, 24, 18, 0, 0),
            new DateTime(2026, 10, 1, 18, 0, 0),
            new DateTime(2026, 10, 8, 18, 0, 0)
        };

        static int[] sessionDurations =
        {
            120,
            180,
            150,
            120,
            180
        };

        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("Welcome to Academy Schedule Analyzer");
            Console.WriteLine();

            while (running)
            {
                ShowMenu();

                int option = ReadMenuOption();

                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        DisplayAllSessions();
                        break;

                    case 2:
                        SearchForSession();
                        break;

                    case 3:
                        SortSessionNames();
                        break;

                    case 4:
                        ReverseSessionNames();
                        break;

                    case 5:
                        FindSessionIndex();
                        break;

                    case 6:
                        CheckIfSessionExists();
                        break;

                    case 7:
                        ShowDurationStatistics();
                        break;

                    case 8:
                        ShowSessionDateDetails();
                        break;

                    case 9:
                        ShowPastAndUpcomingSessions();
                        break;

                    case 10:
                        FindNextSession();
                        break;

                    case 11:
                        CompareTwoSessionDates();
                        break;

                    case 12:
                        ReadAndValidateCustomDate();
                        break;

                    case 13:
                        SelectSessionByIndex();
                        break;

                    case 14:
                        ValidateSessionDuration();
                        break;

                    case 15:
                        GenerateReportUsingString();
                        break;

                    case 16:
                        GenerateReportUsingStringBuilder();
                        break;

                    case 0:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                }

                if (running)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        // Part 31 - Console Menu
        static void ShowMenu()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("       Academy Schedule Analyzer");
            Console.WriteLine("==============================================");
            Console.WriteLine("1. Display all sessions");
            Console.WriteLine("2. Search for a session");
            Console.WriteLine("3. Sort session names");
            Console.WriteLine("4. Reverse session names");
            Console.WriteLine("5. Find session index");
            Console.WriteLine("6. Check if session exists");
            Console.WriteLine("7. Show duration statistics");
            Console.WriteLine("8. Show session date details");
            Console.WriteLine("9. Show past and upcoming sessions");
            Console.WriteLine("10. Find next session");
            Console.WriteLine("11. Compare two session dates");
            Console.WriteLine("12. Read and validate a custom date");
            Console.WriteLine("13. Select session by index");
            Console.WriteLine("14. Validate session duration");
            Console.WriteLine("15. Generate report using string");
            Console.WriteLine("16. Generate report using StringBuilder");
            Console.WriteLine("0. Exit");
            Console.WriteLine("==============================================");
        }

        // Part 2 - Display all sessions
        static void DisplayAllSessions()
        {
            Console.WriteLine("All Sessions:");
            Console.WriteLine();

            for (int i = 0; i < sessionNames.Length; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {sessionNames[i]}");

                Console.WriteLine(
                    $"   Date: {sessionDates[i]:yyyy-MM-dd HH:mm}");

                Console.WriteLine(
                    $"   Duration: {sessionDurations[i]} minutes");

                Console.WriteLine();
            }
        }

        // Part 3 - Search for a session
        static void SearchForSession()
        {
            Console.Write("Enter session name to search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < sessionNames.Length; i++)
            {
                if (sessionNames[i].Equals(
                    searchName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine("Session found!");
                    Console.WriteLine($"Name: {sessionNames[i]}");
                    Console.WriteLine(
                        $"Date: {sessionDates[i]:yyyy-MM-dd HH:mm}");
                    Console.WriteLine(
                        $"Duration: {sessionDurations[i]} minutes");

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Session not found.");
            }
        }

        // Part 4 - Sort session names
        static void SortSessionNames()
        {
            string[] sortedNames =
                (string[])sessionNames.Clone();

            Array.Sort(sortedNames);

            Console.WriteLine("Sorted session names:");

            foreach (string name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }

        // Part 4 - Reverse session names
        static void ReverseSessionNames()
        {
            string[] reversedNames =
                (string[])sessionNames.Clone();

            Array.Reverse(reversedNames);

            Console.WriteLine("Reversed session names:");

            foreach (string name in reversedNames)
            {
                Console.WriteLine(name);
            }
        }

        // Part 4 - Find session index
        static void FindSessionIndex()
        {
            Console.Write("Enter session name: ");
            string name = Console.ReadLine();

            int index = Array.FindIndex(
                sessionNames,
                session => session.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase));

            if (index >= 0)
            {
                Console.WriteLine(
                    $"Session index: {index}");
            }
            else
            {
                Console.WriteLine("Session not found.");
            }
        }

        // Part 4 - Check if session exists
        static void CheckIfSessionExists()
        {
            Console.Write("Enter session name: ");
            string name = Console.ReadLine();

            bool exists = Array.Exists(
                sessionNames,
                session => session.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(
                $"Session exists: {exists}");
        }

        // Part 5 - Duration statistics
        static int GetTotalDuration()
        {
            int total = 0;

            foreach (int duration in sessionDurations)
            {
                total += duration;
            }

            return total;
        }

        static double GetAverageDuration()
        {
            return (double)GetTotalDuration()
                / sessionDurations.Length;
        }

        static int GetShortestDuration()
        {
            int shortest = sessionDurations[0];

            foreach (int duration in sessionDurations)
            {
                if (duration < shortest)
                {
                    shortest = duration;
                }
            }

            return shortest;
        }

        static int GetLongestDuration()
        {
            int longest = sessionDurations[0];

            foreach (int duration in sessionDurations)
            {
                if (duration > longest)
                {
                    longest = duration;
                }
            }

            return longest;
        }

        static void ShowDurationStatistics()
        {
            Console.WriteLine("Duration Statistics:");
            Console.WriteLine(
                $"Total: {GetTotalDuration()} minutes");

            Console.WriteLine(
                $"Average: {GetAverageDuration():F2} minutes");

            Console.WriteLine(
                $"Shortest: {GetShortestDuration()} minutes");

            Console.WriteLine(
                $"Longest: {GetLongestDuration()} minutes");
        }

        // Part 6 - DateTime
        static void ShowSessionDateDetails()
        {
            Console.Write("Enter session name: ");
            string name = Console.ReadLine();

            int index = Array.FindIndex(
                sessionNames,
                session => session.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase));

            if (index == -1)
            {
                Console.WriteLine("Session not found.");
                return;
            }

            DateTime date = sessionDates[index];

            Console.WriteLine();
            Console.WriteLine($"Session: {sessionNames[index]}");
            Console.WriteLine(
                $"Date: {date:yyyy-MM-dd}");
            Console.WriteLine(
                $"Time: {date:HH:mm}");
            Console.WriteLine(
                $"Day: {date.DayOfWeek}");
            Console.WriteLine(
                $"Duration: {sessionDurations[index]} minutes");
        }

        // Part 7 - Reference type
        static void ChangeFirstSessionName(string[] names)
        {
            names[0] = "Updated C# Session";
        }

        // Part 8 - ref
        static void ChangeSessionName(
            ref string sessionName)
        {
            sessionName = "Updated Session";
        }

        // Part 9 - out
        static bool GetSessionInfo(
            string name,
            out DateTime date,
            out int duration)
        {
            int index = Array.FindIndex(
                sessionNames,
                session => session.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase));

            if (index >= 0)
            {
                date = sessionDates[index];
                duration = sessionDurations[index];
                return true;
            }

            date = DateTime.MinValue;
            duration = 0;

            return false;
        }

        // Part 10 - params
        static int CalculateTotalDuration(
            params int[] durations)
        {
            int total = 0;

            foreach (int duration in durations)
            {
                total += duration;
            }

            return total;
        }

        // Part 11 - TimeSpan
        static void ShowDurationAsTime()
        {
            Console.Write(
                "Enter duration in minutes: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int minutes))
            {
                TimeSpan duration =
                    TimeSpan.FromMinutes(minutes);

                Console.WriteLine(
                    $"Duration: {duration.Hours} hours " +
                    $"and {duration.Minutes} minutes");
            }
            else
            {
                Console.WriteLine(
                    "Invalid duration.");
            }
        }

        // Part 12 - Compare dates
        static void CompareTwoSessionDates()
        {
            Console.Write(
                "Enter first session name: ");

            string firstName = Console.ReadLine();

            Console.Write(
                "Enter second session name: ");

            string secondName = Console.ReadLine();

            int firstIndex = Array.FindIndex(
                sessionNames,
                session => session.Equals(
                    firstName,
                    StringComparison.OrdinalIgnoreCase));

            int secondIndex = Array.FindIndex(
                sessionNames,
                session => session.Equals(
                    secondName,
                    StringComparison.OrdinalIgnoreCase));

            if (firstIndex == -1 ||
                secondIndex == -1)
            {
                Console.WriteLine(
                    "One or both sessions were not found.");

                return;
            }

            DateTime firstDate =
                sessionDates[firstIndex];

            DateTime secondDate =
                sessionDates[secondIndex];

            Console.WriteLine();

            if (firstDate < secondDate)
            {
                Console.WriteLine(
                    $"{sessionNames[firstIndex]} is earlier.");
            }
            else if (firstDate > secondDate)
            {
                Console.WriteLine(
                    $"{sessionNames[firstIndex]} is later.");
            }
            else
            {
                Console.WriteLine(
                    "Both sessions have the same date.");
            }

            TimeSpan difference =
                secondDate - firstDate;

            Console.WriteLine(
                $"Difference: " +
                $"{Math.Abs(difference.TotalDays):F0} days");
        }

        // Part 13 - Read and validate custom date
        static DateTime ReadSessionDate()
        {
            while (true)
            {
                Console.Write(
                    "Enter date (yyyy-MM-dd HH:mm): ");

                string input = Console.ReadLine();

                if (DateTime.TryParseExact(
                    input,
                    "yyyy-MM-dd HH:mm",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime date))
                {
                    return date;
                }

                Console.WriteLine(
                    "Invalid date. Please try again.");
            }
        }

        static void ReadAndValidateCustomDate()
        {
            DateTime date = ReadSessionDate();

            Console.WriteLine(
                $"Valid date: {date:yyyy-MM-dd HH:mm}");
        }

        // Part 14 - Select session by index
        static void SelectSessionByIndex()
        {
            Console.Write("Enter session index: ");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);

                Console.WriteLine(
                    $"Selected session: {sessionNames[index]}");
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Please enter a valid number.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(
                    "The index is outside the array.");
            }
        }

        // Part 15 - Menu input
        static int ReadMenuOption()
        {
            while (true)
            {
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                if (int.TryParse(
                    input,
                    out int option))
                {
                    if (option >= 0 &&
                        option <= 16)
                    {
                        return option;
                    }
                }

                Console.WriteLine(
                    "Please enter a number from 0 to 16.");
            }
        }

        // Part 16 - Validate duration
        static void ValidateDuration(int duration)
        {
            if (duration <= 0)
            {
                throw new ArgumentException(
                    "Duration must be greater than zero.");
            }

            if (duration > 480)
            {
                throw new ArgumentException(
                    "Duration cannot be more than 480 minutes.");
            }
        }

        static void ValidateSessionDuration()
        {
            Console.Write(
                "Enter session duration in minutes: ");

            string input = Console.ReadLine();

            try
            {
                int duration = int.Parse(input);

                ValidateDuration(duration);

                Console.WriteLine(
                    "The session duration is valid.");
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Part 17 - Past and upcoming sessions
        static void ShowPastAndUpcomingSessions()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Past Sessions:");

            bool foundPast = false;

            for (int i = 0;
                 i < sessionNames.Length;
                 i++)
            {
                if (sessionDates[i] < now)
                {
                    Console.WriteLine(
                        $"{sessionNames[i]} - " +
                        $"{sessionDates[i]:yyyy-MM-dd HH:mm}");

                    foundPast = true;
                }
            }

            if (!foundPast)
            {
                Console.WriteLine(
                    "No past sessions.");
            }

            Console.WriteLine();
            Console.WriteLine("Upcoming Sessions:");

            bool foundUpcoming = false;

            for (int i = 0;
                 i < sessionNames.Length;
                 i++)
            {
                if (sessionDates[i] >= now)
                {
                    Console.WriteLine(
                        $"{sessionNames[i]} - " +
                        $"{sessionDates[i]:yyyy-MM-dd HH:mm}");

                    foundUpcoming = true;
                }
            }

            if (!foundUpcoming)
            {
                Console.WriteLine(
                    "No upcoming sessions.");
            }
        }

        // Part 18 - Find next session
        static void FindNextSession()
        {
            DateTime now = DateTime.Now;

            int nextIndex = -1;

            for (int i = 0;
                 i < sessionDates.Length;
                 i++)
            {
                if (sessionDates[i] >= now)
                {
                    if (nextIndex == -1 ||
                        sessionDates[i] <
                        sessionDates[nextIndex])
                    {
                        nextIndex = i;
                    }
                }
            }

            if (nextIndex == -1)
            {
                Console.WriteLine(
                    "There are no upcoming sessions.");

                return;
            }

            TimeSpan timeUntil =
                sessionDates[nextIndex] - now;

            Console.WriteLine("Next Session:");
            Console.WriteLine(
                $"Name: {sessionNames[nextIndex]}");

            Console.WriteLine(
                $"Date: " +
                $"{sessionDates[nextIndex]:yyyy-MM-dd HH:mm}");

            Console.WriteLine(
                $"Time remaining: " +
                $"{timeUntil.Days} days, " +
                $"{timeUntil.Hours} hours, " +
                $"{timeUntil.Minutes} minutes");
        }

        // Part 19 - Compare two dates
        static void CompareSessionDates(
            DateTime firstDate,
            DateTime secondDate)
        {
            if (firstDate < secondDate)
            {
                Console.WriteLine(
                    "The first date is earlier.");
            }
            else if (firstDate > secondDate)
            {
                Console.WriteLine(
                    "The first date is later.");
            }
            else
            {
                Console.WriteLine(
                    "Both dates are equal.");
            }
        }

        // Part 20 - String
        static string BuildReportUsingString()
        {
            string report = "";

            report +=
                "Academy Schedule Report\n";

            report +=
                "=======================\n";

            for (int i = 0;
                 i < sessionNames.Length;
                 i++)
            {
                report +=
                    $"{i + 1}. " +
                    $"{sessionNames[i]} | " +
                    $"{sessionDates[i]:yyyy-MM-dd HH:mm} | " +
                    $"{sessionDurations[i]} minutes\n";
            }

            return report;
        }

        static void GenerateReportUsingString()
        {
            Console.WriteLine(
                BuildReportUsingString());
        }

        // StringBuilder
        static string BuildReportUsingStringBuilder()
        {
            StringBuilder report =
                new StringBuilder();

            report.AppendLine(
                "Academy Schedule Report");

            report.AppendLine(
                "=======================");

            for (int i = 0;
                 i < sessionNames.Length;
                 i++)
            {
                report.Append(i + 1);
                report.Append(". ");
                report.Append(sessionNames[i]);
                report.Append(" | ");
                report.Append(
                    sessionDates[i]
                    .ToString("yyyy-MM-dd HH:mm"));
                report.Append(" | ");
                report.Append(sessionDurations[i]);
                report.AppendLine(" minutes");
            }

            return report.ToString();
        }

        static void GenerateReportUsingStringBuilder()
        {
            Console.WriteLine(
                BuildReportUsingStringBuilder());
        }
    }
}