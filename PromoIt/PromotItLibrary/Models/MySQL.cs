using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PromotItLibrary.Models
{
    public class MySQL
    {
        public MySqlCommand? Cmd { get; set; }
        //Connection string get\set
        public string Server { get { return _server; } set { _server = value; ConnectionReset(); } }
        public string UserId { get { return _userId; } set { _userId = value; ConnectionReset(); } }
        public string Password { private get { return _password; } set { _password = value; ConnectionReset(); } }
        public string DataBase { get { return _dataBase; } set { _dataBase = value; ConnectionReset(); } }

        private string Stm { get; set; }
        private MySqlDataReader Rdr { get; set; } //multy results
        private MySqlConnection Con { get; set; }

        private string _server;
        private string _userId;
        private string _password;
        private string _dataBase;

        public MySQL() : this("localhost", "root", "admin", "school") // defult settings for connection
            => (Cmd, Stm, Rdr) = (null, null, null);
        public MySQL(string server, string userId, string password, string dataBase)
        {
            (Server, UserId, Password, DataBase) = (server, userId, password, dataBase);
            try { ConnectionOpen(); } catch { Console.WriteLine($"Connection Error\n"); }
        }
        ~MySQL() => ConnectClose();

        public void Procedure(string proc) { Quary(proc); Procedure(); }
        public void Procedure() { if (Cmd != null) Cmd.CommandType = CommandType.StoredProcedure; }
        public void ProcedureParameter<T>(string name, T value) => SetParameter<T>(name, value);
        public bool ProceduteExecute() => QuaryExecute(); 
        public MySqlDataReader? ProceduteExecuteMultyResults() => GetQueryMultyResults();
        public void Quary(string stmQuary) { Stm = stmQuary; SetCmd(); }
        public void SetQuary(string stmQuary) => Quary(stmQuary);
        public void QuaryParameter<T>(string name, T value) => SetParameter(name, value);
        public MySqlDataAdapter QuaryDataAdapter() => new MySqlDataAdapter(Cmd);
        public bool QuaryExecute(string stmQuary) { Quary(stmQuary); return QuaryExecute(); }
        public bool QuaryExecute()  // inserts
        {
            if (Stm == null) { Console.WriteLine("No Quary"); return false; }
            if (Cmd?.CommandType == CommandType.StoredProcedure) { } //procedure
            else if (Cmd?.Parameters.Count > 0) Cmd?.Prepare(); //parametars
            else if (Cmd != null) Cmd.CommandText = Stm; //insert quary
            int? outPut = Cmd?.ExecuteNonQuery();
            NullifiedValues();
            if (outPut != null && outPut > 0) return true;
            Console.WriteLine($"Quary failed, {Stm}");
            return false;
        }
        public void SetParameter<T>(string name, T value) => Cmd?.Parameters.AddWithValue(name, value);
        public bool InsertLine(string stmQuary) => QuaryExecute(stmQuary);
        public bool InsertLine() => QuaryExecute();
        public bool InsertParameters(string stmQuary) => QuaryExecute(stmQuary);
        public bool InsertParameters() => QuaryExecute();
        public MySqlDataReader GetQueryMultyResults() // selects
        {
            MySqlDataReader results = null;
            try
            {
                Rdr = Cmd?.ExecuteReader();
                results = Rdr;
                NullifiedValues(); // cant nullified rdr!, it will nulified results
            }catch {}
            return results;
        }
        public MySqlDataReader Select() => GetQueryMultyResults();
        public MySqlDataReader Select(string stmQuary) { Quary(stmQuary); return Select(); }
        public string QuaryScalarExecute() { if (Stm == null) return "NoQuery"; string output = Cmd?.ExecuteScalar().ToString(); NullifiedValues(); return output; } //1 value data as string
        public void ConnectClose() { if (Con != null && Con.State == ConnectionState.Open) { NullifiedValues(); Rdr = null; Con.Close(); } } //close connection to database

        private void SetCmd() => Cmd = ((Stm, Cmd) != (null, null) ? new MySqlCommand(Stm, Con) : null);
        private void NullifiedValues() { (Stm, Cmd) = (null, null); } //myview = null;
        private string ConnectionString() => Server != null && UserId != null && Password != null && DataBase != null
            ? @$"server={Server};userid={UserId};password={Password};database={DataBase}" : null;
        private void ConnectionOpen()
        {
            if (ConnectionString() == null || Con != null && Con?.State != ConnectionState.Closed)
                { Console.WriteLine("No connection sting"); return; }
            //else
            Con = new MySqlConnection(ConnectionString()); Con.Open(); SetCmd(); 
        }
        private void ConnectionReset() { if (Con != null && Con.State == ConnectionState.Open) { ConnectClose(); ConnectionOpen(); } } // recheck
    }
}