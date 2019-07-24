using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTest_BulkInsert
{
    public class BulkUploadToSql
    {
        private List<MyRecord> internalStore;

        private ExcelWorksheet excelWorksheet;

        private List<SetupParameter> setupParameters;


        protected string tableName;

        protected DataTable dataTable = new DataTable();

        protected int recordCount;

        protected int commitBatchSize;

        private BulkUploadToSql(string tableName, int commitBatchSize)
        {
            internalStore = new List<MyRecord>();

            this.tableName = tableName;

            this.dataTable = new DataTable(tableName);

            this.recordCount = 0;

            this.commitBatchSize = commitBatchSize;

            // Setup Parameters

            InitializeParameters();
            // add columns to this data table

            InitializeStructures();

        }

        private BulkUploadToSql() : this("AssetRecord", 1000) { }

        private string[] getColumnsName()
        {
            List<string> listacolumnas = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = $"select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = '{this.tableName}' and t.type = 'U'";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listacolumnas.Add(reader.GetString(0));
                    }
                }
            }
            return listacolumnas.ToArray();
        }

        private void InitializeStructures()
        {
            foreach (var i in setupParameters)
            {
                RegisterColumn(i);
            }
        }

        protected virtual void InitializeParameters()
        {
            setupParameters = new List<SetupParameter>();
            setupParameters.Add(new SetupParameter("Client", typeof(string), "Demo"));
            setupParameters.Add(new SetupParameter("Job", typeof(string)));
            setupParameters.Add(new SetupParameter("AssetId", typeof(string),columnNameInSpreadsheet :"Asset Id"));
            //setupParameters.Add(new SetupParameter("ComponentId", typeof(string)));
        }

        /// <summary>
        /// Read Work Sheet Header
        /// </summary>
        protected virtual void InitializeParameterIndex()
        {

            for (int col = 1; col < excelWorksheet.Dimension.Columns; col++)
            {
                var cell = excelWorksheet.Cells[1, col];
                foreach (var parameter in setupParameters)
                {
                    parameter.SetIndex(cell.Value.ToString(), col);
                }

            }
        }

        private void RegisterColumn(SetupParameter parameter)
        {
            dataTable.Columns.Add(parameter.P_columnName, parameter.P_type);
        }

        private void WriteToDatabase()
        {
            // get your connection string

            string connString = ConnectionString;

            // connect to SQL

            using (SqlConnection connection = new SqlConnection(connString))

            {

                // make sure to enable triggers

                // more on triggers in next post

                SqlBulkCopy bulkCopy = new SqlBulkCopy(

                    connection,

                    SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers | SqlBulkCopyOptions.UseInternalTransaction,

                    null

                    );

                // set the destination table name

                bulkCopy.DestinationTableName = this.tableName;

                connection.Open();

                // write the data in the "dataTable"

                bulkCopy.WriteToServer(dataTable);

                connection.Close();

            }

            // reset

            this.dataTable.Clear();

            this.recordCount = 0;

        }

        protected virtual string ConnectionString => "Server=tcp:dev-fvp-sql.database.windows.net,1433;Initial Catalog=fvp-database_Copy;Persist Security Info=False;User ID=la;Password=VTS344sam;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;";

        public void Flush()

        {

            // transfer data to the datatable

            foreach (MyRecord rec in this.internalStore)

            {
                this.PopulateDataTable(rec);

                if (this.recordCount >= this.commitBatchSize)

                    this.WriteToDatabase();

            }

            // write remaining records to the DB

            if (this.recordCount > 0)

                this.WriteToDatabase();

        }

        public virtual void Flush(int batchSize)
        {
            InitializeParameterIndex();

            for (int i = 2; i < this.excelWorksheet.Dimension.Rows; i++)
            {
                DataRow row;
                row = this.dataTable.NewRow();

                foreach (var parameter in setupParameters)
                {
                    if (parameter.DefaultValue != null)
                    {
                        row[parameter.P_columnName] = parameter.DefaultValue;
                    }
                    else if (parameter.P_index > 0)
                    {

                        // populate the values

                        // using your custom logic

                        row[parameter.P_columnName] = excelWorksheet.Cells[i, parameter.P_index];

                        // add it to the base for final addition to the DB

                    }
                }
                this.dataTable.Rows.Add(row);

                this.recordCount++;


                if (this.recordCount >= batchSize)

                    this.WriteToDatabase();

            }



            // write remaining records to the DB

            if (this.recordCount > 0)

                this.WriteToDatabase();
        }

        private void PopulateDataTable(MyRecord record)

        {

            DataRow row;

            // populate the values

            // using your custom logic

            row = this.dataTable.NewRow();

            row["Client"] = record.Client;

            row["AssetId"] = record.AssetId;

            row["Job"] = record.Job;

            row["Component"] = record.Component;

            row["ComponentId"] = record.ComponentId;
            // add it to the base for final addition to the DB

            this.dataTable.Rows.Add(row);

            this.recordCount++;

        }

        private void PopulateDataTable(DataRow dataRow)
        {
            DataRow row;

            // populate the values

            // using your custom logic

            row = this.dataTable.NewRow();

            foreach (var o in setupParameters)
            {
                row[o.P_columnName] = dataRow[o.P_columnName];
            }
            // add it to the base for final addition to the DB

            this.dataTable.Rows.Add(row);

            this.recordCount++;
        }

        public static BulkUploadToSql Load(Stream dataSource)
        {
            // create a new object to return

            BulkUploadToSql o = new BulkUploadToSql();

            // replace the code below

            // with your custom logic 

            for (int cnt = 0; cnt < 20; cnt++)
            {
                MyRecord rec;
                if (cnt % 2 == 1)
                {
                    rec = new MyRecord("Test", "Test Job", $"ID{cnt}", $"Component{cnt}");
                }
                else
                {
                    rec = new MyRecord("Test", "Test Job", $"ID{cnt}", $"Component{cnt}", $"ComponentId{cnt}");
                }
                o.internalStore.Add(rec);
            }
            return o;
        }

        public static BulkUploadToSql Load(ExcelPackage e)
        {
            BulkUploadToSql o = new BulkUploadToSql();

            o.excelWorksheet = e.Workbook.Worksheets["Asset Register"];

            if (o != null)
                return o;
            else
                throw new NullReferenceException("SpreadSheet Not Exist");
        }


    }

    public struct SetupParameter
    {
        public string P_columnName;
        public string P_columnName_in_SpreadSheet;
        public Type P_type;
        public int P_index;
        public string DefaultValue;


        public SetupParameter(string columnName, Type type)
        {
            this.P_columnName = columnName.TrimStart().TrimEnd();
            this.P_type = type;
            this.P_index = -1;
            this.DefaultValue = null;
            this.P_columnName_in_SpreadSheet = this.P_columnName;
        }
        public SetupParameter(string columnName, Type type, string defaultValue = null, string columnNameInSpreadsheet = null) : this(columnName, type)
        {
            this.DefaultValue = defaultValue;
            if (!String.IsNullOrEmpty(columnNameInSpreadsheet)&& !String.IsNullOrWhiteSpace(columnNameInSpreadsheet))
            {
                this.P_columnName_in_SpreadSheet = columnNameInSpreadsheet; 
            }
        }

        public void SetIndex(string columnName, int index)
        {
            if (columnName.TrimStart().TrimEnd().ToLower() == P_columnName_in_SpreadSheet.TrimStart().TrimEnd().ToLower())
            {
                P_index = index;
            }
        }
    }
}
