using Newtonsoft.Json.Linq;
using System.Data;
using System.Reflection;
using System.Xml.Linq;
using Vote.DataAccess;
using Vote.Entities;

namespace Vote.Service
{
    public class VoteService
    {
        static Repository<UserEntity> userRepo = new Repository<UserEntity>();

        static Dictionary<int, int> votedFor = new Dictionary<int, int>();

        public static void NewLoginInApplication()
        {

            Console.WriteLine("Enter first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter date of bitrh:");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            UserEntity user = new UserEntity
            {
                FirstName = fName,
                LastName = lName,
                DateOfBirth = birthDate
            };

            do
            {
                Console.WriteLine("\nSelect operation:");
                Console.WriteLine("1. Add new topic.");
                Console.WriteLine("2. Vote in existing topic.");
                Console.WriteLine("3. View all topics.");
                Console.WriteLine("4. View result.");
                Console.WriteLine("5. Save");
                Console.WriteLine("6. Exit");

                int operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        AddTopic();
                        break;
                    case 2:
                        VoteForTopic(user);
                        break;
                    case 3:
                        ViewAllTopics();
                        break;
                    case 4:
                        ChooseResultMethod();
                        break;
                    case 5:
                        userRepo.Create(user);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
        public static void AddTopic()
        {   
            var topicRepo = new Repository<TopicEntity>();
            var topic = new TopicEntity();
            Console.WriteLine("Enter topic name:");
            string topicName = Console.ReadLine();
            topic.TopicName = topicName;
            topicRepo.Create(topic);
            AddOption(topic.Id);
        }

        public static void AddOption(int topicId)
        {           
            do
            {
                var optionRepo = new Repository<OptionEntity>();
                var option = new OptionEntity(); 
                Console.WriteLine();
                Console.WriteLine("Create new option? 1 - Yes, 2 - No");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Enter option:");
                    string optionString = Console.ReadLine();
                    option.OptionDescription = optionString;
                    option.TopicId = topicId;
                    optionRepo.Create(option);
                }
                else break;
            } while (true);
        }

        public static void ViewAllTopics()
        {
            foreach (var topic in new Repository<TopicEntity>().GetAll())
            {
                Console.WriteLine($"Topic {topic.Id}: {topic.TopicName}");
            }
        }

        public static void ViewAllOptions(int topicId)
        {
            var cnt = 1;
            Console.Clear();
            Console.WriteLine(new Repository<TopicEntity>().Get(topicId).TopicName);
            foreach (var option in new Repository<OptionEntity>().GetAll())
            {
                if(option.TopicId == topicId)
                {
                    Console.WriteLine($"Option {cnt}: {option.OptionDescription}");
                    cnt++;
                }
            }
        }

        public static void VoteForTopic(UserEntity user)
        {
            var topicRepo = new Repository<TopicEntity>();
            var optionRepo = new Repository<OptionEntity>();

            Console.WriteLine("Choose topic to vote:");
            ViewAllTopics();
            int chosenTopic = int.Parse(Console.ReadLine());          
            ViewAllOptions(chosenTopic);
            int chosenOption = int.Parse(Console.ReadLine());
            var topicVoted = topicRepo.Get(chosenTopic).Id;
            var optionVoted = optionRepo.Get(chosenOption).Id;

            
            votedFor.Add(topicVoted, optionVoted);
            user.VotedFor = votedFor;
        }

        public static void ViewAllUsers()
        {
            foreach (var user in new Repository<UserEntity>().GetAll())
            {
                Console.WriteLine($"{user.Id}.{user.FirstName} {user.LastName} {user.DateOfBirth}");
            }
        }

        public static void ResultByUser()
        {
            Repository<UserEntity> userRepo = new Repository<UserEntity>();
            Repository<TopicEntity> topicRepo = new Repository<TopicEntity>();
            Repository<OptionEntity> optionRepo = new Repository<OptionEntity>();
            ViewAllUsers();
            Console.WriteLine("Select user number:");
            int userNumber = int.Parse(Console.ReadLine());
            var userRecords = userRepo.Get(userNumber);
            var topicLocal = topicRepo.GetAll();
            var optionLocal = optionRepo.GetAll();
                        
            foreach(var x in userRecords.VotedFor)
            {
                foreach(var y in topicLocal)
                {
                    if (y.Id == x.Key)
                    {
                        foreach (var z in optionLocal)
                        {
                            if (z.Id == x.Value)
                            {
                                Console.WriteLine($"User {userRecords.FirstName} {userRecords.LastName} voted in topic {y.TopicName} for option {z.OptionDescription}");
                            }
                        }
                    }
                }
                
            }
        }

        public static void ResultByTopic()
        {
            Repository<UserEntity> userRepo = new Repository<UserEntity>();

            ViewAllTopics();
            Console.WriteLine("Select topic number:");
            int topicNumber = int.Parse(Console.ReadLine());
            var userLocal = userRepo.GetAll();

            foreach (var x in userLocal)
            {
                if (x.VotedFor.ContainsKey(topicNumber))
                {
                    Console.WriteLine($"Users, that voted in this topic: {x.FirstName} {x.LastName}");
                }
            }
        }
        
        public static void ChooseResultMethod()
        {
            Console.WriteLine("\nResult by:");
            Console.WriteLine("1. User");
            Console.WriteLine("2. Topic");
            int result = int.Parse(Console.ReadLine());
            if(result == 1)
            {
                ResultByUser();
            } 
            else if (result == 2)
            {
                ResultByTopic();
            }
        }
    }
}
