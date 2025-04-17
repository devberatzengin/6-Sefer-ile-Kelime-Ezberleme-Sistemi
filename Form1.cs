using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _6_Sefer_ile_Kelime_Ezberleme_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(registerUsernameTextBox.Text) || string.IsNullOrWhiteSpace(registerPasswordTextBox.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!");
                return;
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True");
            sqlConnection.Open();

            // Kullanıcı kontrol 
            SqlCommand checkUserCommand = new SqlCommand("SELECT COUNT(*) FROM tblUser WHERE UserName = @username", sqlConnection);
            checkUserCommand.Parameters.AddWithValue("@username", registerUsernameTextBox.Text.Trim());
            int userExists = (int)checkUserCommand.ExecuteScalar();

            if (userExists > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış!");
                return;
            }

            // Max UserId'i al
            SqlCommand getMaxIdCommand = new SqlCommand("SELECT ISNULL(MAX(UserId), 0) FROM tblUser", sqlConnection);
            int nextUserId = (int)getMaxIdCommand.ExecuteScalar() + 1;

            // Yeni kullanıcıyı ekle
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblUser (UserId, UserName, UserPassword) VALUES (@id, @username, @password)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", nextUserId);
            sqlCommand.Parameters.AddWithValue("@username", registerUsernameTextBox.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@password", registerPasswordTextBox.Text.Trim());

            int result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız. Lütfen tekrar deneyin.");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginUsernameTextBox.Text) || string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!");
                return;
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT UserName, UserPassword FROM tblUser WHERE UserName = @username AND UserPassword = @password", sqlConnection);

            // Parametreler
            sqlCommand.Parameters.AddWithValue("@username", loginUsernameTextBox.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@password", loginPasswordTextBox.Text.Trim());

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            // Kullanıcı kontrol 
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(resetUsernameTextBox.Text) || string.IsNullOrWhiteSpace(resetPasswordTextBox.Text))
            {
                MessageBox.Show("Lütfen boş bırakmayınız!");
                return;
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source=BERATZ\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True");
            sqlConnection.Open();

            // Kullanıcı kontrol 
            SqlCommand checkUserCommand = new SqlCommand("SELECT COUNT(*) FROM tblUser WHERE UserName = @username", sqlConnection);
            checkUserCommand.Parameters.AddWithValue("@username", resetUsernameTextBox.Text.Trim());
            int userExists = (int)checkUserCommand.ExecuteScalar();

            if (userExists > 0)
            {
                MessageBox.Show("Kullanıcı bulundu!");

                SqlCommand sqlCommand = new SqlCommand("UPDATE tblUser SET UserPassword = @password WHERE UserName = @username", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", resetUsernameTextBox.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@password", resetPasswordTextBox.Text.Trim());

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Güncelleme başarılı!");
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız. Lütfen kullanıcı adından emin olun.");
                }
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı bulunamadı!");
            }
        }
    }
}
