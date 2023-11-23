using DataAccess;
using Entities;

namespace WFATelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserRepository ur = new UserRepository();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Surname = txtSurname.Text;
            person.PhoneNumber = mtxtPhone.Text;

            ur.Add(person);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var list = ur.GetByNameOrSurname(txtSearch.Text);
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person person = ur.GetById(Id);
            ur.Update(person, txtName.Text, txtSurname.Text, mtxtPhone.Text);
        }

        int Id;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            Id = (int)dataGridView1[0, index].Value;
            FillTexts();
        }

        public void FillTexts()
        {
            Person person = ur.GetById(Id);
            txtName.Text = person.Name;
            txtSurname.Text = person.Surname;
            mtxtPhone.Text = person.PhoneNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = ur.GetAll();
            dataGridView1.DataSource = users;
        }
    }
}