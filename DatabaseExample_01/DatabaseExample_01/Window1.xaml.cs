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

namespace DatabaseExample_01
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnExecuteScalar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true");
            //cn.ConnectionString = ;

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select count(*) from Employees";
            cmd.CommandText = "select Name from Employees where DeptNo = 20";
            //MessageBox.Show("Count of Employee = "+cmd.ExecuteScalar().ToString());
            MessageBox.Show(cmd.ExecuteScalar().ToString());
            cn.Close();
        }

        private void btnDataReader_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString= @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectEmployees";
            
            //If you want to read more than 1 value then use ExecuteReader() then get obj and pass to DataReader
            SqlDataReader dr = cmd.ExecuteReader();
            
            //dr.Read()->T/F will return true or false
            while (dr.Read())
            {
                //lstEmployee.Items.Add(dr["Name"].ToString());
                lstEmployee.Items.Add(dr["Name"].ToString());
            }

            //dr.Close();
            cn.Close();
        }

        private void btnExecuteReader_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees; select * from Departments";
            SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    lstEmployee.Items.Add(dr["Name"]);
            //    //lstEmployee.Items.Add(dr["DeptNo"]);
            //}
            
            dr.NextResult();
            while (dr.Read())
            {
                lstEmployee.Items.Add(dr["DeptName"]);
            }
            dr.Close();
            cn.Close();
        }

        private void btnMARS_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmdDepts = new SqlCommand();
            cmdDepts.Connection = cn;
            cmdDepts.CommandType = CommandType.Text;
            cmdDepts.CommandText = "select * from Departments";

            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = CommandType.Text;
            
            SqlDataReader drDepts = cmdDepts.ExecuteReader();
            while (drDepts.Read())
            {
                lstEmployee.Items.Add(drDepts["DeptName"]);

                cmdEmps.CommandText = "Select * from Employees where DeptNo = " + drDepts["DeptNo"];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    lstEmployee.Items.Add(" -->" + drEmps["Name"]);
                }
                drEmps.Close();
            }

            drDepts.Close();
            cn.Close();
        }



        private SqlDataReader Getdata()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true;MultipleActiveResultSets=true";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectEmployees";
            
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
            cn.Close();
        }

        private void btnDataReadFromFunction_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader dr = Getdata();
            while (dr.Read())
            {
                lstEmployee.Items.Add(dr["Name"] +" "+ dr["DeptNo"]);
            }
            dr.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            
        }
    }
}
