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
    /// Inserts the Values into the database
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
        try{
            string procedure = "sp_insert_data";
            MySqlCommand command = new MySqlCommand(procedure, mysql_connection);
            command.CommandType =CommandType.StoredProcedure;

            command.Parameters.AddWithValue("p_listeneinkaufspreis",listeneinkaufspreis);
            command.Parameters.AddWithValue("p_lieferrabatt",lieferrabatt);
            command.Parameters.AddWithValue("p_zieleinkaufspreis",zieleinkaufspreis);
            command.Parameters.AddWithValue("p_lieferskonto",lieferskonto);
            command.Parameters.AddWithValue("p_bareinkaufspreis",bareinkaufspreis);
            command.Parameters.AddWithValue("p_bezugskosten",bezugskosten);
            command.Parameters.AddWithValue("p_bezugspreis",bezugspreis);
            command.Parameters.AddWithValue("p_handlungskostenzuschlag",handlungskostenzuschlag);
            command.Parameters.AddWithValue("p_selbskosten",selbskosten);
            command.Parameters.AddWithValue("p_gewinnzuschlag",gewinnzuschlag);
            command.Parameters.AddWithValue("p_barverkaufspreis",barverkaufspreis);
            command.Parameters.AddWithValue("p_kundenskonto_und_vertreterprovision",kundenskonto_und_vertreterprovision);
            command.Parameters.AddWithValue("p_zielverkaufspreis",zielverkaufspreis);
            command.Parameters.AddWithValue("p_kundenrabatt",kundenrabatt);
            command.Parameters.AddWithValue("p_nettoverkaufspreis",nettoverkaufspreis);
            command.Parameters.AddWithValue("p_umsatzsteuer",umsatzsteuer);
            command.Parameters.AddWithValue("p_bruttoverkaufspreis",bruttoverkaufspreis);

            command.ExecuteNonQuery();
        }
        catch(Exception ex){
            Console.WriteLine(ex.ToString());
        }
    }
}