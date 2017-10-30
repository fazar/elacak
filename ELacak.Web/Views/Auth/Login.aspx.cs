using ELacak.Services.Interfaces;
using ELacak.Web.IoC;
using ELacak.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ELacak.Web.Views.Auth
{
    public partial class Login : BasePageWithIoC
    {
        public IUserService UserService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var username = (LoginForm.FindControl("UserName") as TextBox).Text;
            var password = (LoginForm.FindControl("Password") as TextBox).Text;
            var rememberMe = (LoginForm.FindControl("RememberMe") as CheckBox).Checked;
            ValidateUserResponse response = ValidateUser(username, password);

            if (response.IsSuccess)
            {
                if (!string.IsNullOrEmpty(response.User.DefaultUrl) && response.User.DefaultUrl != null)
                {
                    Response.Redirect(response.User.DefaultUrl, false);
                }
                
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        private ValidateUserResponse ValidateUser(string userName, string password)
        {
            ValidateUserResponse response = new ValidateUserResponse();
            var user = UserService.Login(userName, password);
            if (user != null)
            {

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                UserViewModel serializedModel = new UserViewModel
                {
                    Id = user.Id,
                    Username = user.Username,
                    Email = user.Email,
                    DepartmentId = user.DepartmentId,
                    DepartmentName = user.DepartmentName,
                    IsActive = user.IsActive,
                    IsSuperAdmin = user.IsSuperAdmin,
                    DefaultUrl = user.DefaultUrl
                };

                if (user.Roles.Count() > 0)
                {
                    string[] roles = new string[user.Roles.Count()];
                    int i = 0;
                    foreach (var role in user.Roles)
                    {
                        roles[i] = role.Name;
                        i++;
                    }
                    serializedModel.Roles = roles;
                }

                string userData = serializer.Serialize(serializedModel);
                FormsAuthenticationTicket formAuthTicket = null;
                formAuthTicket = new FormsAuthenticationTicket(1, user.Email, DateTime.Now, DateTime.Now.AddMinutes(15), false, userData);
                string encformAuthTicket = FormsAuthentication.Encrypt(formAuthTicket);
                HttpCookie formAuthCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encformAuthTicket);
                System.Web.HttpContext.Current.Response.Cookies.Add(formAuthCookie);
                response.IsSuccess = true;
                response.User = serializedModel;
            }
            return response;
        }

        public class ValidateUserResponse
        {
            public bool IsSuccess { get; set; }
            public UserViewModel User { get; set; }
        }
    }
}