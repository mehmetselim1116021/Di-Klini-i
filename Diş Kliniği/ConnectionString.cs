﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Diş_Kliniği
{
     class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti=new SqlConnection();
            baglanti.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eseli\OneDrive\Belgeler\DentalDb.mdf;Integrated Security=True;Connect Timeout=30";
            return baglanti;
        }
    }
}
