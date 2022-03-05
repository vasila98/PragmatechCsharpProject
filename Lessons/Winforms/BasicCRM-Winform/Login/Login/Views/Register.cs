using System;
using System.Windows.Forms;

namespace Login.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public int Id { get; private set; }
        public object Email { get; private set; }
        public object Password { get; private set; }

        public void getUserData(object sender, EventArgs e )
        {

        
            //var id = new Random();
            //{
            //    Id = id.Next(1, 1000);
            //    Name = this.Name.Text.
            //    Email = this.Email.Text,
            //    Password = this.Password.Text,
            //}
            
            

            MessageBox.Show(Db.DbContext.Users[0].Id.ToString());

        }
    }
}
