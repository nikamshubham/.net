using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
//using DatabaseExample_01.MyDataSetTableAdapters;

namespace DatabaseExample_01
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        DataSet ds;
        //MyDataSet ds1;
        private void btnDataAdapter_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from Employees",cn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            
            SqlDataAdapter da = new SqlDataAdapter();
            //To fetch data from database
            
            da.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            //Fill the dataAdapter and it will create a data Table inside a data Set
            //Emps - data table name if yopu dont give this it will create with some Default table name
            //If you are working with only one table then you don't need to create data set then datatable use

            da.Fill(ds, "Emps");
            //da.Fill(dt);

            //Every Datatable has a DefaultView Associated with it
            //dgGridEmps.ItemsSource = ds.Tables[0].DefaultView;
            dgGridEmps.ItemsSource = ds.Tables["Emps"].DefaultView;
            //dgGridEmps.ItemsSource = dt.DefaultView;

            cn.Close();

        }

        private void btnDataAdapter2_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from Employees",cn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            SqlDataAdapter da = new SqlDataAdapter();
            //To fetch data from database
            da.SelectCommand = cmd;
            DataTable ds = new DataTable();
            //Fill the dataAdapter and it will create a data Table inside a data Set
            //Emps - data table name if you dont give this it will create with some Default table name
            //If you are working with only one table then you don't need to create data set then datatable use
            
            da.Fill(ds);
            //Every Datatable has a DefaultView Associated with it
            dgGridEmps.ItemsSource = ds.DefaultView;
            cn.Close();

        }

        private void btnDataAdapter3_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds, "Emps");

            cmd.CommandText = "select * from Departments";

            //SqlDataAdapter da2 = new SqlDataAdapter();
            //da2.SelectCommand = cmd;

            da.Fill(ds, "Deps");
            dgGridEmps.ItemsSource = ds.Tables["Emps"].DefaultView;
            DgGridDepartment.ItemsSource = ds.Tables["Deps"].DefaultView;

            cn.Close();
        }


        
        private void btnValidation_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectEmployees";

            SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;

            ds = new DataSet();
            da.Fill(ds, "Emps");

            cmd.CommandText = "SelectDepartments";
            da.Fill(ds, "Deps");

            //primary key validation
            DataColumn[] arrCols = new DataColumn[1];
            arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
            ds.Tables["Emps"].PrimaryKey = arrCols;


            //foreign key validation
            ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"], ds.Tables["Emps"].Columns["DeptNo"]);

            //Column Level Constraint
            ds.Tables["Emps"].Columns["Name"].Unique = true;

            //column level constraints
            ds.Tables["Deps"].Columns["DeptName"].Unique = true;

            //dgEmps.ItemsSource = ds.Tables[0].DefaultView;
            dgGridEmps.ItemsSource = ds.Tables["Emps"].DefaultView;
            //dgEmps.ItemsSource = ds.Tables["Deps"].DefaultView;
            cn.Close();

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true"); 
            cn.Open();
            //cmdUpdate
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = CommandType.StoredProcedure;
            cmdUpdate.CommandText = "UpdateEmployee";

            //values are present in DataSet and not in Command text and this Update will run more than once
            //When you have Single value and want to call it once then use this statement
            //cmdUpdate.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);

            //cmdUpdate.Parameters.Add(p);

            //DataRowVersion = Enum{Default,Original,Current,Proposed}
            //ParameterName = String
            //SourceColumn = String->While updating which column you want to change
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName="@Name",SourceColumn="Name",
                SourceVersion = DataRowVersion.Current });
            
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic",SourceColumn = "Basic",
                SourceVersion = DataRowVersion.Current
            });
            cmdUpdate.Parameters.Add(new SqlParameter{ ParameterName = "@DeptNo",SourceColumn = "DeptNo",
                SourceVersion = DataRowVersion.Current
            });
            cmdUpdate.Parameters.Add(new SqlParameter{ParameterName = "@EmpNo",SourceColumn = "EmpNo",
                SourceVersion = DataRowVersion.Original
            });

            //cmdInsert
            SqlCommand cmdInsert = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = CommandType.StoredProcedure;
            cmdUpdate.CommandText = "InsertEmployee";

            //insert parameter
            cmdInsert.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Name",
                SourceColumn = "Name",
                SourceVersion = DataRowVersion.Current
            });

            cmdInsert.Parameters.Add(new SqlParameter
            {
                ParameterName = "@EmpNo",
                SourceColumn = "EmpNo",
                SourceVersion = DataRowVersion.Current
            });

            cmdInsert.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Basic",
                SourceColumn = "Basic",
                SourceVersion = DataRowVersion.Current
            });

            cmdInsert.Parameters.Add(new SqlParameter
            {
                ParameterName = "@DeptNo",
                SourceColumn = "DeptNo",
                SourceVersion = DataRowVersion.Current
            });



            //cmdDelete
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = cn;
            cmdDelete.CommandType = CommandType.StoredProcedure;
            cmdDelete.CommandText = "DeleteEmployee";

           
            //DeleteEmployee
            cmdDelete.Parameters.Add(new SqlParameter 
            { 
                ParameterName = "@EmpNo" ,
                SourceColumn="EmpNo", 
                SourceVersion=DataRowVersion.Current
            });
            
            
            SqlDataAdapter da = new SqlDataAdapter();
            
            da.UpdateCommand = cmdUpdate;
            da.InsertCommand = cmdInsert;
            da.DeleteCommand = cmdDelete;
               
            
            da.Update(ds, "Emps");
            
            cn.Close();
            
        }

        
        //private void btnFill_Click(object sender, RoutedEventArgs e)
        //{
        //    ds1 = new MyDataSet();
        //    DepartmentsTableAdapter daDeps = new DepartmentsTableAdapter();
        //    daDeps.Fill(ds.Departments);

        //    EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
        //    daEmps.Fill(ds.Employees);

        //    dgEmps.ItemsSource = ds.Employees.DefaultView;
        //}
    }
}
