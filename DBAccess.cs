﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WheelOfFortune
{
    internal class DBAccess
    {
        public static List<PhraseClass> GetWords()
        {
            using (var conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<PhraseClass>("SELECT DISTINCT Phrases.Phrase, Categories.Category FROM Phrases JOIN Categories ON Categories.CategoryID = Phrases.CategoryID ORDER BY RANDOM() LIMIT 3");
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
