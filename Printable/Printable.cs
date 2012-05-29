using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;

namespace FinelineDatabase.Printable
{
    /// <summary>
    /// Super class for all of the Printable Database activity. 
    /// </summary>
    public class Printable
    {
        /// <summary>
        /// Printable connection string
        /// </summary>
        protected static string printableConnString = "Data Source=SQL1;Initial Catalog=Printable;User ID=FPGwebservice;Password=kissmygrits;Connect Timeout=160";

        /// <summary>
        /// Database query method. Queries Printable.dbo.* with the passed string parameter.
        /// </summary>
        /// <param name="q">String query</param>
        protected ArrayList queryDatabase(string q)
        {
            ArrayList temp = new ArrayList();

            try
            {
                using (SqlConnection conn = new SqlConnection(printableConnString))
                {
                    SqlCommand command = new SqlCommand(q, conn);
                    try
                    {
                        command.Connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            object[] values = new object[reader.FieldCount];
                            reader.GetValues(values);
                            temp.Add(values);
                        }

                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        Console.Beep();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.Beep();
            }

            return temp;
        }

        /// <summary>
        /// Database query method. Queries and returns an integer from a scalar execution.
        /// </summary>
        /// <param name="q">String query</param>
        /// <returns>Integer from query, COUNT(*), etc...</returns>
        protected int countDatabase(string q)
        {
            int temp = 0;

            using (SqlConnection conn = new SqlConnection(printableConnString))
            {
                SqlCommand command = new SqlCommand(q, conn);
                command.Connection.Open();

                if (!Int32.TryParse(command.ExecuteScalar().ToString(), out temp))
                {
                    temp = 0;
                }
            }

            return temp;
        }
    }
}
