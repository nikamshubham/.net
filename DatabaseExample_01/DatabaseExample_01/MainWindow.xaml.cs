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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace DatabaseExample_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Insert
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            //1. Connection
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;";
            //Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;

            //"insert into Employees values(100,'Shubham',25000,10)";
            //"insert into Employees values(100,'Shubham',25000,10)";
            cmd.CommandText = "insert into Employees values(" + txtEmpNo.Text + ",'" + txtName.Text + "',"+ txtBasic.Text + "," + txtDeptNo.Text + ")";
            MessageBox.Show(cmd.CommandText);
            //for insert,update,delete command use ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("okay");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            cn.Close();


        }

        //Insert with Prepared Statement
        private void btnPreparedStatement_Click(object sender, RoutedEventArgs e)
        {
            // Step 1
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;";
            cn.Open();
            //Step 2
            SqlCommand cmd = new SqlCommand();
            //Pass Connection obj to Command
            cmd.Connection = cn;
            // type of Command 
            cmd.CommandType = System.Data.CommandType.Text;
            //Insert Command by Prepared statement 
            cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
            //AddWithvalue is like Collection
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }

        //Insert with Stored Procedure
        private void btnStoredProcedure_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertEmployee";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            cn.Close();
       }

        //Update
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //1. Create Connection Object
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;";
            //Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            //"update Employees set EmpNo = 100",Name = 'Nikam',Basic = 50000,DeptNo = 50";
            //cmd.CommandText = "update Employees set Name = 'Nikam',Basic = 50000,DeptNo = 50 where EmpNo = 101";
            //"update Employees set Name = 'Nikam',Basic = 50000,DeptNo = 50 where EmpNo = 101";
            cmd.CommandText = "update Employees set Name = '" + txtName.Text + "',Basic =" + txtBasic.Text + ",DeptNo =" + txtDeptNo.Text + " where EmpNo = "+txtEmpNo.Text;
            MessageBox.Show(cmd.CommandText);
            //for insert,update,delete command use ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }

        //Update With Prepared Statement
        private void btnUpdatePreparedStatement_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            


            cmd.CommandText = "update Employees set Name = @Name, Basic = @Basic, DeptNo = @DeptNo where EmpNo = @EmpNo";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated with prepared statemenet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }

        //Update with Stored Procedure
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "UpdateEmployee";

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("okay");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }

        //Delete 
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "delete from Employees where EmpNo = 101";
            cmd.CommandText = "delete from Employees where EmpNo = " + txtEmpNo.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted 1 data");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }

        //Delete With Prepared Statement
        private void btnDeleteWithPreparedStatement_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            
            cmd.CommandText = "delete from Employees where EmpNo = @EmpNo";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);

            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted 1 data");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }

        private void btnDeleteWithStoredProcedure_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDB;Initial Catalog=JKDec20;Integrated Security=True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "DeleteEmployee";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);

            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted 1 data");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }
    }
}
