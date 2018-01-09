using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversalManagmentSystem
{
    public partial class UMS : Form
    {
        public UMS()
        {
            InitializeComponent();

            SqlCommand de = new SqlCommand("SelectGroupUser", con);
            SqlDataAdapter d = new SqlDataAdapter(de);
            d.Fill(dt);
            perm.DataSource = dt;
            perm.DisplayMember = "Name";
            perm.ValueMember = "Id";

            SqlCommand gu = new SqlCommand("SelectDepartment", con);
            SqlDataAdapter g = new SqlDataAdapter(gu);
            g.Fill(dt2);
            wor.DataSource = dt2;
            wor.DisplayMember = "Name";
            wor.ValueMember = "Id";

        }


        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;");
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;");
        //SelectEmployee SE = new SelectEmployee();
        string connection = "Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;";
        string whichButton = "";
        private void monoFlat_Panel2_Click(object sender, EventArgs e)
        {
            #region Doctor
            //    Employee.ForeColor =Color.Brown;
            //    EmployeeAro.ForeColor = Color.Brown;
            //    con.Open();

            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText ="SelectEmployees";

            //    DataTable dt = new DataTable();
            //    dt.Columns.Add(new DataColumn("id")); //0
            //    dt.Columns.Add(new DataColumn("Name"));//1
            //    dt.Columns.Add(new DataColumn("Address"));//2
            //    dt.Columns.Add(new DataColumn("Phone"));//3
            //    dt.Columns.Add(new DataColumn("Salary"));//4
            //    dt.Columns.Add(new DataColumn("Email"));//5
            //    dt.Columns.Add(new DataColumn("Birth"));//6
            //    dt.Columns.Add(new DataColumn("Group"));//7
            //    dt.Columns.Add(new DataColumn("Department"));//8
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        DataRow dr = dt.NewRow();
            //        dr[0] = (int)reader[0];
            //        dr[1] = (String)reader[1];
            //        dr[2] = (String)reader[2];
            //        dr[3] = (String)reader[3];
            //        dr[4] = (String)reader[4];
            //        dr[5] = (String)reader[5];
            //        dr[6] = (String)reader[6];
            //        dr[7] = (String)reader[7];
            //        dr[8] = (String)reader[8];
            //        dt.Rows.Add(dr);
            //    }
            //    reader.Close();
            //    dataGridView1.DataSource = dt;

            #endregion

            whichButton = "employee";
            Employee.ForeColor =Color.Brown;
            EmployeeAro.ForeColor = Color.Brown;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor= Color.White;
            SubCategoriesAro.ForeColor= Color.White;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectEmployees", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
               
            }
        }

        private void monoFlat_Panel3_Click(object sender, EventArgs e)
        {
            whichButton = "category";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.Brown;
            CategoriesAro.ForeColor = Color.Brown;
            SubCategories.ForeColor = Color.White;
            SubCategoriesAro.ForeColor = Color.White;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;


            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectCategory", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void monoFlat_Panel9_Click(object sender, EventArgs e)
        {
            whichButton = "subCategory";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor = Color.Brown;
            SubCategoriesAro.ForeColor = Color.Brown;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectSubCategory", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void monoFlat_Panel7_Click(object sender, EventArgs e)
        {
            whichButton = "department";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor = Color.White;
            SubCategoriesAro.ForeColor = Color.White;
            Department.ForeColor = Color.Brown;
            DepartmentAro.ForeColor = Color.Brown;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectDepartment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void monoFlat_Panel6_Click(object sender, EventArgs e)
        {
            whichButton = "supplier";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor = Color.White;
            SubCategoriesAro.ForeColor = Color.White;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.Brown;
            SupplierAro.ForeColor = Color.Brown;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectSupplier", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void monoFlat_Panel5_Click(object sender, EventArgs e)
        {
            whichButton ="product";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor = Color.White;
            SubCategoriesAro.ForeColor = Color.White;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.Brown;
            ProductsAro.ForeColor = Color.Brown;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectProducts", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void monoFlat_Panel8_Click(object sender, EventArgs e)
        {
            whichButton = "bill";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor = Color.White;
            SubCategoriesAro.ForeColor = Color.White;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.Brown;
            BillAro.ForeColor = Color.Brown;
            Order.ForeColor = Color.White;
            OrderAro.ForeColor = Color.White;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectReceipt", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void monoFlat_Panel4_Click(object sender, EventArgs e)
        {
            whichButton = "receipt";
            Employee.ForeColor = Color.White;
            EmployeeAro.ForeColor = Color.White;
            Categories.ForeColor = Color.White;
            CategoriesAro.ForeColor = Color.White;
            SubCategories.ForeColor = Color.White;
            SubCategoriesAro.ForeColor = Color.White;
            Department.ForeColor = Color.White;
            DepartmentAro.ForeColor = Color.White;
            Supplier.ForeColor = Color.White;
            SupplierAro.ForeColor = Color.White;
            Products.ForeColor = Color.White;
            ProductsAro.ForeColor = Color.White;
            Bill.ForeColor = Color.White;
            BillAro.ForeColor = Color.White;
            Order.ForeColor = Color.Brown;
            OrderAro.ForeColor = Color.Brown;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=UniversalManagmentSystem;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("SelectReceipt", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
           
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
         
        }

        private void BackToView_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            

        }

        private void Create_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] parem = new SqlParameter[9];
            parem[0] = new SqlParameter("@EmployeeName", SqlDbType.VarChar, 80);
            parem[0].Value = nam.Text;

            parem[1] = new SqlParameter("@EmployeeAddress", SqlDbType.VarChar, 100);
            parem[1].Value = str.Text;

            parem[2] = new SqlParameter("@EmployeePhone", SqlDbType.VarChar, 12);
            parem[2].Value = pho.Text;

            parem[3] = new SqlParameter("@EmployeeSalary", SqlDbType.Decimal);
            parem[3].Value = Convert.ToDecimal(sal.Text);

            parem[4] = new SqlParameter("@EmployeeEmail", SqlDbType.VarChar, 20);
            parem[4].Value = ema.Text;

            parem[5] = new SqlParameter("@EmployeeBirth", SqlDbType.Date);
            parem[5].Value = Convert.ToDateTime(bir.Text);

            parem[6] = new SqlParameter("@EmployeePassword", SqlDbType.VarChar, 20);
            parem[6].Value = pass.Text;

            parem[7] = new SqlParameter("@GroupUser", SqlDbType.Int);
            parem[7].Value = Convert.ToInt32(perm.SelectedValue);

            parem[8] = new SqlParameter("@Department", SqlDbType.Int);
            parem[8].Value = Convert.ToInt32(wor.SelectedValue);

            cmd.Parameters.AddRange(parem);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("kosom mina helal :)");


            nam.Text = "";
            str.Text = "";
            pho.Text = "";
            sal.Text = "";
            ema.Text = "";
            bir.Text = "";
            pass.Text = "";
            perm.Text = "";
            wor.Text = "";

        }

        private void monoFlat_Button1_Click_1(object sender, EventArgs e)
        {
            switch (whichButton)
            {
                case "supplier":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteSupplier", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "employee":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteEmployees", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "category":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteCategory", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "subCategory":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteSubCategory", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "department":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteDepartment", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "product":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteProduct", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@Id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "bill":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteProductFromBill", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@Id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "receipt":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("DeleteReceipt", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            switch (whichButton)
            {
                case "supplier":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("searchIDSupplier", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "employee":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchEmployee", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "category":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchCategory", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "subCategory":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchSubCategory", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "department":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchDepartment", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "product":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchProduct", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@Id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "bill":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchBill", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@Id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;
                case "receipt":
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = new SqlCommand("SearchReceipt", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //int num = int.Parse();
                            cmd.Parameters.AddWithValue("@id", iTalk_NumericUpDown1.Value);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void iTalk_Button_21_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
