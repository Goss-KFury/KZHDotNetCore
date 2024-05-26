
using KZHDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//SqlConnection

//Ctrl + . =>suggestion
// F10 =>
// F11 =>
// F9 => breakpoint

/* SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "."; // server name
stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; // database name
stringBuilder.UserID = "sa";
stringBuilder.Password = "sasa@123";
SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//SqlConnection connection = new SqlConnection("Data Source=KyawZinHtet;Initial Catalog=KZHDotNetCore;User ID=sa;Password=sasa@123");

connection.Open();
Console.WriteLine("Connection open.");

string query = "select * from Tbl_Blog";
SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);

connection.Close();
Console.WriteLine("Connection close.");

// dataset => datatable
// datatable => datarow
// datarow => datacolum

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id =>" + dr["BlogId"]);
    Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
    Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
    Console.WriteLine("----------------------------");
}
*/

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
// adoDotNetExample.Read();
// adoDotNetExample.Create("title", "author", "content");
// adoDotNetExample.Update(1005, "test title", "test author", "test content");
// adoDotNetExample.Delete(1003);
//adoDotNetExample.Edit(1003);
//adoDotNetExample.Edit(1);

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Run();

Console.ReadKey();