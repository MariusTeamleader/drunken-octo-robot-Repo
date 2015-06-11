using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace DataAccess
{
    /// <summary>
    /// Führt physische Datenzugriffe durch.
    /// </summary>
    public class DataTransfer
    {
        OleDbConnection con = null;
        /// <summary>
        /// Holt die Kundendaten aus der Datenquelle.
        /// </summary>
        /// <returns>Gibt bei Erfolg eine Liste gefüllt mit Kundenobjekten zurück.</returns>
        public List<Kunde> getAlleKunden()
        {         
            if (!OpenConnection())
            {
                return null;
            }
            List<Kunde> kList = new List<Kunde>();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * From Kunden";
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.KundenID = reader.GetValue(0).ToString();
                    k.Name = reader.GetValue(1).ToString();
                    k.Vorname = reader.GetValue(2).ToString();
                    k.GebDat = reader.GetValue(3).ToString();
                    kList.Add(k);
                }
                return kList;
            }
            catch
            {
                return null;
            }
            
        }
        private bool OpenConnection()
        {
            Boolean result = true;
            con = new OleDbConnection(Settings1.Default.ConString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                result = false;
            }      
            return result;
        }
    }
}
