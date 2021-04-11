using dental_sys.model;
using dental_sys.service;
using dental_sys.view;
using Firebase.Auth;
using System;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class LoginPage : Form
    {
        private static string apiKey = "AIzaSyBn9Lqgce4jOQS_84c5yEHlyHaCEi2n9Wc";
        private static string storageBucket = "solveequation-ecf24.appspot.com";
        private static string authDomain = "solveequation-ecf24.firebaseapp.com";
        private static string projectId = "solveequation-ecf24";
        private static string messagingSenderId = "464761191742";
        private static string appId = "1:464761191742:web:067091e2a5454e269d806f";
        private static string measurementId = "G-TGP964ML4R";

        public LoginPage()
        {
            CommonService.SaveUrlApi();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username)
                && !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                EmailTextBox.Text = Properties.Settings.Default.Username;
                PasswordTextBox.Text = Properties.Settings.Default.Password;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login();
        }
        private async void Login()
        {
            var email = EmailTextBox.Text;
            var pass = PasswordTextBox.Text;


            //this.Visible = false;
            //Loading _load = new Loading();
            //_load.Show();
            var waitForm = new WaitFormFunc();
            waitForm.Show(this);
            string mess = null;
            var auth = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            try
            {
                var ab = await auth.SignInWithEmailAndPasswordAsync(email, pass);
                var user = ab.User;
                //var user = 0;
                if (user != null)
                {
                    var authService = new AuthenticationService();
                    //var userLogin = authService.GetToken(user.LocalId);
                    var userLogin = authService.GetToken(user.LocalId);
                    if (userLogin != null)
                    {
                        if (string.IsNullOrEmpty(userLogin.ErrorMessage))
                        {
                            UserLoginModel.AccessToken = userLogin.AccessToken;
                            UserLoginModel.User = userLogin.User;
                            if (RememberCheckbox.Checked)
                            {
                                Properties.Settings.Default.Username = email;
                                Properties.Settings.Default.Password = pass;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.Username = null;
                                Properties.Settings.Default.Password = null;
                                Properties.Settings.Default.Save();
                            }
                        }
                        else
                        {
                            var isAdmin = userLogin.User.Role == 2;
                            mess = !isAdmin ? @"You don't have permission." : userLogin.ErrorMessage;
                        }

                    }
                    else
                    {
                        mess = @"Can't login. Try again later.";
                    }

                }

            }
            catch (Exception e)
            {
                mess = @"Invalid Email or password!";
            }

            waitForm.Close();

            if (!string.IsNullOrEmpty(mess))
            {
                MessageBox.Show(mess);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
