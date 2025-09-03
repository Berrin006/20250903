namespace MainApp
{
    internal static class MenuService
    {

        private static List<string> _name_list = [];
        private static string _option = "";

        public static void DisplayListView()
        {
            Console.WriteLine("1. View List");
            foreach (var name in _name_list)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

        public static void DisplayAddNameToList()
        {
            Console.WriteLine("2. Add To List");
            Console.Write("Enter a name: ");
            string input_name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input_name))
            {
                _name_list.Add(input_name);
            }
        }

        public static void DisplayMenuOptions()
        {
            Console.WriteLine("*** MENU OPTIONS ***");
            Console.WriteLine("1. View List");
            Console.WriteLine("2. Add To List");
            Console.WriteLine("0. Exit Application");

            Console.Write("\n Choose one option: ");
            _option = Console.ReadLine();

            Console.Clear();
        }

        public static void MainMenu()
        {


            do
            {
                DisplayMenuOptions();

                switch (_option)
                {
                    case "1":
                        DisplayListView();
                        break;

                    case "2":
                        DisplayAddNameToList();

                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }


                Console.Clear();
            }

            while (true);
        }

    }
}
