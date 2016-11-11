Facade pattern
--------------

 - Цел   
    - осигурява единен интерфейс към множество вътрешни интерфейси в дадена система. Facade дефинира интерфейс, който улеснява използването на системата
	- обвива сложна система с по-прост    интерфейс
 - Употреба
	- Когато клиента изисква опростен интерфейс за достъп до сложна система
 - Описание
Facade описва обвиването на сложен код и функционалност с един интерфейс. Това позволява да се намали времето, небходимо за заучаване на интерфейса на  сложната система. Освен това намалява обвървзванеот  на клиента с тази система. От друга страна, обаче Facade може даскрие специфична фунционалност от клиента.

    interface IHomeSystem
        {
            void DisplayHomeScreen();
        }
    class HomeSystem:IHomeSystem
        {
            public void DisplayHomeScreen()
            {
                Console.WriteLine("Hello, please login with username and password");
            }
        }
        
        interface IUserManagementSystem
        {
            bool VerifyUserCredentials(string username, string password);
    
            void ConnectToUserDB();
    }
    class UserManagementSystem:IUserManagementSystem
        {
            public bool VerifyUserCredentials(string username, string password)
            {
                Console.WriteLine("User {0} looged in", username);
                return true;
            }
    
            public void ConnectToUserDB()
            {
                Console.WriteLine("Connect to users DataBase");
            }
        }
        
        interface IDataProcessor
        {
            void ConnectToDB();
    
            string ProcessData();
    class DataProcessor:IDataProcessor
        {
    
            public void ConnectToDB()
            {
                Console.WriteLine("Connected to DataBase");
            }
    
            public string ProcessData()
            {
                return "Usefull data";
            }
        }
    class Facade:IFacade
        {
            private IHomeSystem homeSys = new HomeSystem();
            private IUserManagementSystem users = new UserManagementSystem();
            private IDataProcessor data = new DataProcessor();
    
            public void Logging(string username, string password)
            {
                homeSys.DisplayHomeScreen();
                users.ConnectToUserDB();
                users.VerifyUserCredentials(username, password);
                data.ConnectToDB();
                Console.WriteLine(data.ProcessData());
            }
        }

