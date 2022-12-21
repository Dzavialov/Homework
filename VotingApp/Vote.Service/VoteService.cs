using System.Xml.Linq;
using Vote.DataAccess;
using Vote.Entities;

namespace Vote.Service
{
    public class VoteService
    {
        public static void NewLoginInApplication()
        {
            var userRepo = new Repository<UserEntity>();
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

            userRepo.Create(user);

            Console.WriteLine("Select operation operation:");
            Console.WriteLine("1. Add new topic");
            Console.WriteLine("2. Vote in existing topic");
            Console.WriteLine("3. View all topics");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddTopic(user.Id);
                    break;
                case 2:
                    VoteForTopic(user);
                    break;
                case 3:
                    ViewAllTopics();
                    break;
            }
        }

        public static void AddTopic(int userId)
        {
            var topicRepo = new Repository<TopicEntity>();
            Console.WriteLine("Enter topic name:");
            string topicName = Console.ReadLine();
            TopicEntity topic = new TopicEntity
            {
                TopicName = topicName,
                UserId = userId
            };
            topicRepo.Create(topic);
            AddOption(topic.Id);
        }

        public static void AddOption(int topicId)
        {
            var optionRepo = new Repository<OptionEntity>();
            do
            {
                Console.WriteLine("Create new option? 1 - Yes, 2 - No");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Enter option:");
                    string optionString = Console.ReadLine();
                    OptionEntity option = new OptionEntity
                    {
                        OptionDescription = optionString,
                        TopicId = topicId
                    };
                    optionRepo.Create(option);
                }
                else break;
            } while (true);
        }

        public static void ViewAllTopics()
        {
            int cnt = 1;
            foreach (var topic in new Repository<TopicEntity>().GetAll())
            {
                Console.WriteLine($"Topic {cnt}: {topic.TopicName}");
                cnt++;
            }

            Console.WriteLine("Choose topic to watch it options:");
            int topicId = int.Parse(Console.ReadLine());
            ViewAllOptions(topicId);
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
            Console.WriteLine("Choose topic to vote:");
            ViewAllTopics();
            int chosenTopic = int.Parse(Console.ReadLine());
            user.TopicVoted = chosenTopic;
            ViewAllOptions(chosenTopic);
            int chosenOption = int.Parse(Console.ReadLine());
            user.OptionVoted = chosenOption;
        }
    }
}
