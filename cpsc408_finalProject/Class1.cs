using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class Class1
{
	public Class1()
	{
        string myConnectionString = "server=localhost;database=cpsc408_final;uid=andrewdieken;pwd=HelpJeep97;";
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=cpsc408_final;uid=andrewdieken;pwd=HelpJeep97;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
    }
}
