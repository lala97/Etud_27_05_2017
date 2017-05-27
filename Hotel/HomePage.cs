using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Hotel
{
    public partial class HomePage : Form
    {
    

        List<User> UserList = new List<User>();
        DataTable table = new DataTable();
        string filterField = "Country";

        public HomePage()
        {
            InitializeComponent();

        }

       

        private void HomePage_Load(object sender, EventArgs e)
        {  
            // first grid
            UserList.Add(new User("1", "lala", "Mamedova"));      
            UserList.Add(new User("3", "Farid", "Babayev"));
            BindingList<User> list = new BindingList<User>(UserList);
            dataGridUser.DataSource = list;  // dataGridView  list ile form load olankimi data gorunmesi ucun bura yazdiq



            // second grid 
            // dataGridView  DataTable ile form load olankimi data gorunmesi ucun bura yazdiq  Search ucun
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Sales", typeof(int));
            // static olaraq table data elave etdik
            table.Rows.Add(new object[] { "Argentina", "kamran", 2000 });
            table.Rows.Add(new object[] { "Belgium", "Seymur", 4500 });
            table.Rows.Add(new object[] { "dcjbjdsc", "Adel", 3500 });
            table.Rows.Add(new object[] { "rgentina", "polad", 2000 });
            table.Rows.Add(new object[] { "aze", "Renat", 4500 });
            table.Rows.Add(new object[] { "dcjbjdsc", "Adel", 3500 });

            dataSearch.DataSource = table;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            UserList.Add(new User(txt_add_id.Text, txt_add_name.Text, txt_add_surname.Text));
            BindingList<User> list = new BindingList<User>(UserList);
            dataGridUser.DataSource = list;  // dataGridView  with list

        // dataGridView  textBox ile 
            //    dataGridUser.Rows.Add(txt_add_id.Text, txt_add_name.Text, txt_add_surname.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {          
            string searchValue = txt_id.Text;

            txt_id.Clear();

            try
            {
                for (int i = 0; i < dataGridUser.Rows.Count; i++)
                {
                    //1) row selected olunubsa silsin 
                    if (dataGridUser.Rows[i].Selected == true)
                    {
                        dataGridUser.Rows.RemoveAt(i);                                      
                    }

                    // 2)textBox-dan id gelirse silsn
                    if (!dataGridUser.Rows[i].IsNewRow)
                    {
                        if (dataGridUser[0, i].Value.ToString() == searchValue)
                        {                         
                            dataGridUser.Rows.RemoveAt(i);
                        }
                        else
                            dataGridUser.Rows[i].Selected = false;
                    }
                }

            }                    
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridUser.Rows.Count; i++)
            {   // selected olunmus row-un datalarin textBox-larin Text-ne yazir
                if (dataGridUser.Rows[i].Selected == true)
                {
                    txt_add_id.Text = dataGridUser.Rows[i].Cells[0].Value.ToString();
                    txt_add_name.Text = dataGridUser.Rows[i].Cells[1].Value.ToString();
                    txt_add_surname.Text = dataGridUser.Rows[i].Cells[2].Value.ToString();                   
                }
            }
         }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // data search olunur
            table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, textBox1.Text);
        }
    }
}
