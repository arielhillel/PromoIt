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

        private string stm { get; set; }
        private MySqlDataReader rdr { get; set; } //multy results
        private MySqlConnection con { get; set; }

        private string _server;
        private string _userId;
        private string _password;
        private string _dataBase;

        public MySQL() : this("localhost", "root", "admin", "school") // defult settings for connection
            => (Cmd, stm, rdr) = (null, null, null);
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
        public void Quary(string stmQuary) { stm = stmQuary; SetCmd(); }
        public void SetQuary(string stmQuary) => Quary(stmQuary);
        public void QuaryParameter<T>(string name, T value) => SetParameter(name, value);
        public MySqlDataAdapter QuaryDataAdapter() => new MySqlDataAdapter(Cmd);
        public bool QuaryExecute(string stmQuary) { Quary(stmQuary); return QuaryExecute(); }
        public bool QuaryExecute()  // inserts
        {
            if (stm == null) { Console.WriteLine("No Quary"); return false; }
            if (Cmd?.CommandType == CommandType.StoredProcedure) { } //procedure
            else if (Cmd?.Parameters.Count > 0) Cmd?.Prepare(); //parametars
            else if (Cmd != null) Cmd.CommandText = stm; //insert quary
            int? outPut = Cmd?.ExecuteNonQuery();
            NullifiedValues();
            if (outPut != null && outPut > 0) return true;
            Console.WriteLine($"Quary failed, {stm}");
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
                rdr = Cmd?.ExecuteReader();
                results = rdr;
                NullifiedValues(); // cant nullified rdr!, it will nulified results
            }catch {}
            return results;
        }
        public MySqlDataReader Select() => GetQueryMultyResults();
        public MySqlDataReader Select(string stmQuary) { Quary(stmQuary); return Select(); }
        public string QuaryScalarExecute() { if (stm == null) return "NoQuery"; string output = Cmd?.ExecuteScalar().ToString(); NullifiedValues(); return output; } //1 value data as string
        public void ConnectClose() { if (con != null && con.State == ConnectionState.Open) { NullifiedValues(); rdr = null; con.Close(); } } //close connection to database

        private void SetCmd() => Cmd = ((stm, Cmd) != (null, null) ? new MySqlCommand(stm, con) : null);
        private void NullifiedValues() { (stm, Cmd) = (null, null); } //myview = null;
        private string ConnectionString() => Server != null && UserId != null && Password != null && DataBase != null
            ? @$"server={Server};userid={UserId};password={Password};database={DataBase}" : null;
        private void ConnectionOpen()
        {
            if (ConnectionString() == null || con != null && con?.State != ConnectionState.Closed)
                { Console.WriteLine("No connection sting"); return; }
            //else
            con = new MySqlConnection(ConnectionString()); con.Open(); SetCmd(); 
        }
        private void ConnectionReset() { if (con != null && con.State == ConnectionState.Open) { ConnectClose(); ConnectionOpen(); } } // recheck
    }
}