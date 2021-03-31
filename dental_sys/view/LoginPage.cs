using dental_sys.service;
using Firebase.Auth;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class LoginPage : Form
    {
        CustomerService customerService = new CustomerService();
        private static string apiKey = "AIzaSyBn9Lqgce4jOQS_84c5yEHlyHaCEi2n9Wc";
        private static string storageBucket = "solveequation-ecf24.appspot.com";
        private static string authDomain = "solveequation-ecf24.firebaseapp.com";
        private static string projectId = "solveequation-ecf24";
        private static string messagingSenderId = "464761191742";
        private static string appId = "1:464761191742:web:067091e2a5454e269d806f";
        private static string measurementId = "G-TGP964ML4R";
        private static string email = "admin@gmail.com";
        private static string pass = "admin@123";
        public LoginPage()
        {
            customerService.GetUrl();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login();
        }
        private async void login()
        {
            string email = guna2TextBox1.Text;
            string pass = guna2TextBox2.Text;
            //this.Visible = false;
            //Loading _load = new Loading();
            //_load.Show();
            var auth = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            FirebaseAuthLink ab = null;
            try
            {
                //ab = await auth.SignInWithEmailAndPasswordAsync(email, pass);
                //string token = ab.FirebaseToken;
                //var user = ab.User;

                var user = 0;
                if (user != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                //Loading _load = new Loading();
                //_load.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid Email or password!");
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
