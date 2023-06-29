namespace _14._List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> userList= GetListFromInput();
            List<int> stringLength = GetElementLengthInList(userList);
            int length = 0;
            foreach (string item in userList)
            {
                Console.Write ($"Zodis is saraso: {item} ");
                for( int i =length; i<stringLength.Count; i++)
                {
                    Console.WriteLine ($"ilgis: {stringLength[i]}");
                    break;
                }
                length++;    
            }
           
        }
        static List<string> GetListFromInput()
        {
            List<string> listFromInput = new List<string>();
            Console.WriteLine("Sarasas:");
            bool whileStatus = true;
            while (whileStatus)
            {
                Console.WriteLine("Ivesikte norima zodi, kuris prides i sarasa");
                listFromInput.Add(Console.ReadLine());
                Console.WriteLine("Ar noresite dar papilditi sarasa?(taip/ne)");
                var userChoose = Console.ReadLine();
                if (userChoose == "taip")
                {
                    continue;
                }
                whileStatus = false;
            }
            return listFromInput;
        }

        static List<int> GetElementLengthInList(List<string> userList) 
        { 
            List<int> userListEveryStringLength = new List<int>();  
        foreach (string stringLength in userList) 
            { 
                userListEveryStringLength.Add(stringLength.Length);
            }
           return userListEveryStringLength;
        }
    }
}