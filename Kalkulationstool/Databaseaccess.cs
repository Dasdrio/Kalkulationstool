public class Databasaccess
{
    private static Databaseaccess? instance;
    private String mysql_connection_string = "server=localhost;port=3306;uid=root;pwd=bfwhd;database=kalkulationstool";
    private static MySqlConnection mysql_connection;
    private static MySqlCommand? command;

    private Databaseaccess(){
        mysql_connection = new MySqlConnection();
        try{
            mysql_connection.ConnectionString = mysql_connection_string;
            mysql_connection.Open();
        }catch(MySqlException ex){
            Console.WriteLine(ex.ToString());
        }
    }
    /// <summary>
    /// Closes and destroys the instance of the database
    /// </summary>
    public static void close_database(){
        if(instance != null){
            mysql_connection.Close();
            instance = null;
        }
    }

    /// <summary>
    /// Creates an instance of the database or returns an existing one
    /// </summary>
    /// <returns>the instance for the database acces</returns>
    public static Database_access get_instance(){ 
        if(instance == null){
            instance = new Database_access();
            return instance;  
        }else{
            return instance;    
        }
    }
}