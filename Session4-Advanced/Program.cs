using System.Reflection.Metadata;

namespace Session4_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = new List<int> {88,95,72,97,60,75,99,61};

            //2. Print the collection, Count, first and last grade
            //Console.WriteLine("Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //Console.WriteLine($"Count:{grades.Count}");
            //Console.WriteLine($"First grade:{grades[0]}");
            //Console.WriteLine($"Last grade:{grades[^1]}");

            //3. Sort the grades ascending, then print
            //grades.Sort();

            //Console.WriteLine("Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //4. Get the first grade above 90
            //int firstAbove90 = grades.Find(grade => grade > 90);
            //Console.WriteLine($"{firstAbove90}");

            //5. Get all grades below 75 (failing grades)
            //List<int> failingGrades = grades.FindAll(grade => grade < 75);

            //Console.WriteLine("Failing grades:");
            //foreach (int grade in failingGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //6. Remove all failing grades (below 75)
            //grades.RemoveAll(grade => grade < 75);

            //7. Check if any grade equals 100
            //bool gradeAbove100 = grades.Exists(grade => grade == 100);
            //Console.WriteLine($"{gradeAbove100}");

            //8. Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradeStrings = new List<string>();

            //foreach (int grade in grades)
            //{
            //    gradeStrings.Add($"Grade: {grade}");
            //}
            //foreach (string grade in gradeStrings)
            //{
            //    Console.WriteLine(grade);
            //}
            #endregion

            #region Exercise 2: Leaderboard
            //1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //SortedDictionary<int,string> leaderboard = new SortedDictionary<int,string>();

            //leaderboard.Add(500,"Ahmed");
            //leaderboard.Add(200,"Sara");
            //leaderboard.Add(800,"Ali");
            //leaderboard.Add(350,"Mona");

            //2. Print all entries (they should be sorted by score automatically)
            //Console.WriteLine("Leaderboard:");

            //foreach (KeyValuePair<int,string> player in leaderboard)
            //{
            //    Console.WriteLine(player);
            //}

            //3. Access the first key and first value
            //foreach (KeyValuePair<int,string> player in leaderboard)
            //{
            //    Console.WriteLine($"First Key: {player.Key}");
            //    Console.WriteLine($"First Value: {player.Value}");
            //    break;
            //}

            //4. Check if score 500 exists
            //bool result = leaderboard.ContainsKey(500);
            //Console.WriteLine(result);

            //5. Safely get the player with score 999
            //string? playerName;

            //if (leaderboard.TryGetValue(999,out playerName))
            //{
            //    Console.WriteLine(playerName);
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            //6. Remove the player with score 200 and print the updated list
            //leaderboard.Remove(200);

            //foreach (KeyValuePair<int,string> player in leaderboard)
            //{
            //    Console.WriteLine(player);
            //}
            #endregion

            #region Exercise 3: Phone Book
            //1. Create a Collection with 4 contacts (name → phone number)
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //phoneBook.Add("Ahmed","01010101011");
            //phoneBook.Add("Mostafa","01111010101");
            //phoneBook.Add("Ali","01212012120");
            //phoneBook.Add("Omar","01010106688");

            //2. Add a new contact using [] syntax (add or update)
            //phoneBook["Ammar"] = "01215141716";

            //3. Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    phoneBook.Add("Ahmed","01112315161");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("the key has already been added");
            //}

            //4. Try adding a duplicate using .TryAdd() — print whether it succeeded
            //bool result = phoneBook.TryAdd("Ahmed","01020304474");
            //Console.WriteLine(result);

            //5. Search for a contact that doesn’t exist
            //if (phoneBook.TryGetValue("Khaled",out string phone))
            //{
            //    Console.WriteLine(phone);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            //6. Get a contact with a fallback of "Not Found"
            //string result = phoneBook.GetValueOrDefault("Khaled","Not Found");
            // Console.WriteLine(result);

            //7. Print all Keys on one line, then all Values on another line
            //Console.WriteLine("Names:");
            //Console.WriteLine(string.Join(", ",phoneBook.Keys));

            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine("Phone Numbers:");
            //Console.WriteLine(string.Join(", ", phoneBook.Values));
            #endregion

            #region Exercise 4: Unique Email Validator
            //1. Create a HashSet<string> with a case-insensitive comparer:
            //new HashSet<string>(StringComparer.OrdinalIgnoreCase)

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //2. Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //3. Print Count — how many are actually stored? Explain why.
            //Console.WriteLine(emails.Count);

            //4. Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            //HashSet<int> setA = [1, 2, 3, 4, 5];
            //HashSet<int> setB = [4, 5, 6, 7, 8];

            //5. Print the result of: UnionWith, IntersectWith, ExceptWith
            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine("Union:");
            //Console.WriteLine(string.Join(", ",union));

            //HashSet<int> intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);
            //Console.WriteLine("Intersection:");
            //Console.WriteLine(string.Join(", ",intersect));

            //HashSet<int> except = new HashSet<int>(setA);
            //except.ExceptWith(setB);
            //Console.WriteLine("Except:");
            //Console.WriteLine(string.Join(", ",except));

            //6.Use IsSubsetOf to check if { 1,2} is a subset of Set A
            //HashSet<int> smallSet = [1,2];

            //bool result = smallSet.IsSubsetOf(setA);
            //Console.WriteLine(result);
            #endregion

            #region Exercise 5: Print Queue Simulator
            //1. Print the queue contents and Count
            //Queue<string> documents = new Queue<string>();

            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");

            //foreach (string document in documents)
            //{
            //    Console.WriteLine(document);
            //}
            //Console.WriteLine($"Count:{documents.Count}");

            //Console.WriteLine("-------------------------------------------------------");

            //2. Use Peek to see which document will print next (without removing)
            //Console.WriteLine(documents.Peek());

            //3. Process the queue: Dequeue each document and print "Printing: [name]"
            //while (documents.Count > 0)
            //{
            //    string document = documents.Dequeue();
            //    Console.WriteLine($"Printing:{document}");
            //}

            //4. Try TryDequeue on the now-empty queue — what happens?
            //bool Dequed = documents.TryDequeue(out string? document);
            //Console.WriteLine(Dequed);
            //Console.WriteLine(document);
            #endregion

            #region Exercise 6: Browser History (Undo)
            //1. Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"
            //Stack<string> browserHistory = new Stack<string>();

            //browserHistory.Push("google.com");
            //browserHistory.Push("github.com");
            //browserHistory.Push("stackoverflow.com");
            //browserHistory.Push("youtube.com");
            //browserHistory.Push("claude.ai");

            //2. Use Peek to see the current page (top of stack)
            //Console.WriteLine(browserHistory.Peek());

            //3. Press "back" 3 times using Pop — print each page you leave
            //for (int i = 0; i < 3; i++)
            //{
            //    string page = browserHistory.Pop();
            //    Console.WriteLine(page);
            //}

            //4. Print the current page after going back
            //Console.WriteLine($"Current page:{browserHistory.Peek()}");

            //5. Try TryPop on an empty stack — what happens?
            //bool result = browserHistory.TryPop(out string? browser);
            //Console.WriteLine(result);
            //Console.WriteLine(browser);
            #endregion
        }
    }
}
