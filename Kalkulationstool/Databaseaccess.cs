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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="listeneinkaufspreis"></param>
    /// <param name="lieferrabatt"></param>
    /// <param name="zieleinkaufspreis"></param>
    /// <param name="lieferskonto"></param>
    /// <param name="bareinkaufspreis"></param>
    /// <param name="bezugskosten"></param>
    /// <param name="bezugspreis"></param>
    /// <param name="handlungskostenzuschlag"></param>
    /// <param name="selbskosten"></param>
    /// <param name="gewinnzuschlag"></param>
    /// <param name="barverkaufspreis"></param>
    /// <param name="kundenskonto_und_vertreterprovision"></param>
    /// <param name="zielverkaufspreis"></param>
    /// <param name="kundenrabatt"></param>
    /// <param name="nettoverkaufspreis"></param>
    /// <param name="umsatzsteuer"></param>
    /// <param name="bruttoverkaufspreis"></param>
    public static void insert_data(decimal listeneinkaufspreis,decimal lieferrabatt, decimal zieleinkaufspreis, decimal lieferskonto, decimal bareinkaufspreis, decimal bezugskosten, decimal bezugspreis, decimal handlungskostenzuschlag, decimal selbskosten, decimal gewinnzuschlag,decimal barverkaufspreis, decimal kundenskonto_und_vertreterprovision,decimal zielverkaufspreis, decimal kundenrabatt, decimal nettoverkaufspreis, decimal umsatzsteuer, decimal bruttoverkaufspreis)
    {
        
    }
}